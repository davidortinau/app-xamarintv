

using CommunityToolkit.Maui;
using Maui.PancakeView;
using Sharpnado.Tabs;

namespace XamarinTV;

public static class MauiProgramExtensions
{
    public static MauiAppBuilder UseSharedMauiApp(this MauiAppBuilder builder)
    {
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkitMediaElement()
            .UseMauiCommunityToolkit()
            .UseSharpnadoTabs(false)
            .UsePancakeViewCompat()
            ;

        return builder;
    }
}
