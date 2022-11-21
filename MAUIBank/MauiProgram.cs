using CommunityToolkit.Maui;
using MAUIBank.ViewModels;
using MAUIBank.Views;

namespace MAUIBank;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        _ = builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("Font Awesome 6 Free-Solid-900.otf", "FASolid");
                fonts.AddFont("Font Awesome 6 Brands-Regular-400.otf", "FABrands");
                fonts.AddFont("Font Awesome 6 Free-Regular-400.otf", "FARegular");
            });

        builder.Services.AddTransient<PinPage>();
        builder.Services.AddTransient<PinPageViewModel>();

        builder.Services.AddTransient<CardPage>();
        builder.Services.AddTransient<CardPageViewModel>();

        return builder.Build();
    }
}
