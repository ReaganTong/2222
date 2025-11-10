using Microsoft.Extensions.Logging;
using Lab_2.Views;         // Add this
using Lab_2.ViewModels;    // Add this
using Prism;
using Prism.DryIoc;        // Add this

namespace Lab_2
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UsePrism((prism) =>  // Add the .UsePrism() method
                {
                    prism.RegisterTypes(container =>
                    {
                        // This tells Prism that when MainPage is loaded,
                        // its BindingContext should be a new MainPageViewModel.
                        container.RegisterForNavigation<MainPage, MainPageViewModel>();
                    });
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}