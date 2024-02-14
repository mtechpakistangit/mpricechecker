using Microsoft.Extensions.Logging;

namespace M_PriceCheker
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
                    fonts.AddFont("LeagueSpartan-Black.ttf", "LeagueSpartan-Black");
                    fonts.AddFont("LeagueSpartan-Bold.ttf", "LeagueSpartan-Bold");
                    fonts.AddFont("LeagueSpartan-ExtraBold.ttf", "LeagueSpartan-ExtraBold");
                    fonts.AddFont("LeagueSpartan-ExtraLight.ttf", "LeagueSpartan-ExtraLight");
                    fonts.AddFont("LeagueSpartan-Light.ttf", "LeagueSpartan-Light");
                    fonts.AddFont("LeagueSpartan-Medium.ttf", "LeagueSpartan-Medium");
                    fonts.AddFont("LeagueSpartan-Regular.ttf", "LeagueSpartan-Regular");
                    fonts.AddFont("LeagueSpartan-SemiBold.ttf", "LeagueSpartan-SemiBold");
                    fonts.AddFont("LeagueSpartan-Thin.ttf", "LeagueSpartan-Thin");
                    fonts.AddFont("Poppins-Black.ttf", "Poppins-Black");
                    fonts.AddFont("Poppins-Bold.ttf", "Poppins-Bold");
                    fonts.AddFont("Poppins-ExtraBold.ttf", "Poppins-ExtraBold");
                    fonts.AddFont("Poppins-ExtraLight.ttf", "Poppins-ExtraLight");
                    fonts.AddFont("Poppins-Light.ttf", "Poppins-Light");
                    fonts.AddFont("Poppins-Medium.ttf", "Poppins-Medium");
                    fonts.AddFont("Poppins-Regular.ttf", "Poppins-Regular");
                    fonts.AddFont("Poppins-SemiBold.ttf", "Poppins-SemiBold");
                    fonts.AddFont("Poppins-Thin.ttf", "Poppins-Thin");
                    fonts.AddFont("introrust-base.otf", "introrust-base");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
