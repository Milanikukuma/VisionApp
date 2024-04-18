using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;
using PicSight.Configuration;
using PicSight.View;
using PicSight.ViewModels;

namespace PicSight
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
                });

            builder.Services.RegisterServices();
            builder.Services.RegisterViewModels();
            builder.Services.RegisterView();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<CameraService, CameraService>();
            services.AddTransient<ISettings, ConstantSettings>();
            return services;
        }

        public static IServiceCollection RegisterViewModels(this IServiceCollection services)
        {
            services.AddSingleton<BaseViewModel>();
            return services;
        }

        public static IServiceCollection RegisterView(this IServiceCollection services)
        {
            services.AddSingleton<ImagedisplayPage>();
            return services;
        }
    }
}
