namespace HandlersDemo.Controls
{
    public enum ImageAlignment
    {
        Left,
        Right
    }

    public class ImageEntry : Entry
    {
        public static readonly BindableProperty ImageProperty =
            BindableProperty.Create(nameof(Image), 
                typeof(string), 
                typeof(ImageEntry), 
                string.Empty);

        public int ImageWidth
        {
            get { return (int)GetValue(ImageWidthProperty); }
            set { SetValue(ImageWidthProperty, value); }
        }

        public static readonly BindableProperty ImageHeightProperty =
             BindableProperty.Create(nameof(ImageHeight), 
                 typeof(int), 
                 typeof(ImageEntry), 
                 50);

        public int ImageHeight
        {
            get { return (int)GetValue(ImageHeightProperty); }
            set { SetValue(ImageHeightProperty, value); }
        }

        public static readonly BindableProperty ImageWidthProperty =
            BindableProperty.Create(nameof(ImageWidth), 
                typeof(int), 
                typeof(ImageEntry), 
                50);

        public string Image
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly BindableProperty ImageAlignmentProperty =
            BindableProperty.Create(nameof(ImageAlignment), 
                typeof(ImageAlignment), 
                typeof(ImageEntry), 
                ImageAlignment.Left);

        public ImageAlignment ImageAlignment
        {
            get { return (ImageAlignment)GetValue(ImageAlignmentProperty); }
            set { SetValue(ImageAlignmentProperty, value); }
        }
    }
}
