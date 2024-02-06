using Microsoft.Extensions.Logging;
using HandlersDemo.Controls;

namespace HandlersDemo
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .ConfigureMauiHandlers((handlers) =>
                {
#if ANDROID
                    handlers.AddHandler(typeof(ImageEntry), typeof(Platforms.Android.Handlers.ImageEntryHandler));
#elif IOS
                    handlers.AddHandler(typeof(ImageEntry), typeof(Platforms.iOS.Handlers.ImageEntryRenderer));

#endif
                });

#if DEBUG
    builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
