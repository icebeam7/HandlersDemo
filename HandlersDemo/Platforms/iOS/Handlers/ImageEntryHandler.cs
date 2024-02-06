using UIKit;

using System.Drawing;

using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

using HandlersDemo.Controls;

namespace HandlersDemo.Platforms.iOS.Handlers
{
    public class ImageEntryRenderer : EntryHandler
    {
        private ImageEntry element;

        protected override MauiTextField CreatePlatformView()
        {
            var textField = new MauiTextField();
            element = VirtualView as ImageEntry;

            if (!string.IsNullOrEmpty(element.Image))
            {
                switch (element.ImageAlignment)
                {
                    case ImageAlignment.Left:
                        textField.LeftViewMode = UITextFieldViewMode.Always;
                        textField.LeftView = GetImageView(element.Image, element.ImageHeight, element.ImageWidth);
                        break;
                    case ImageAlignment.Right:
                        textField.RightViewMode = UITextFieldViewMode.Always;
                        textField.RightView = GetImageView(element.Image, element.ImageHeight, element.ImageWidth);
                        break;
                }
            }

            textField.BorderStyle = UITextBorderStyle.Line;
            textField.Layer.MasksToBounds = true;

            return textField;
        }

        private UIView GetImageView(string imagePath, int height, int width)
        {
            var uiImageView = new UIImageView(UIImage.FromFile(imagePath))
            {
                Frame = new RectangleF(0, 0, width, height)
            };
            UIView objLeftView = new UIView(new System.Drawing.Rectangle(0, 0, width + 10, height));
            objLeftView.AddSubview(uiImageView);

            return objLeftView;
        }
    }
}
