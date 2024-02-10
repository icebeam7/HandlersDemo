using Microsoft.Extensions.Logging;
using HandlersDemo.Controls;
using HandlersDemo.Handlers;

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
                    handlers.AddHandler(typeof(ImageEntry), typeof(ImageEntryHandler));
                });

#if DEBUG
    builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
