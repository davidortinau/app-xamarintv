using FFImageLoading.Forms.Platform;
using XamarinTV.ViewModels;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.ViewManagement;
using Microsoft.UI.Xaml;

namespace XamarinTV.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            CachedImageRenderer.Init();

            LoadApplication(new XamarinTV.App());

            NativeCustomize();
        }

        void NativeCustomize()
        {
            // PC Customization
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.ApplicationView"))
            {
                // TODO Windows.UI.ViewManagement.ApplicationView is no longer supported. Use Microsoft.UI.Windowing.AppWindow instead. For more details see https://docs.microsoft.com/en-us/windows/apps/windows-app-sdk/migrate-to-windows-app-sdk/guides/windowing
                var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                if (titleBar != null)
                {
                    titleBar.BackgroundColor = (Color)App.Window.Resources["NativeAccentColor"];
                    titleBar.ButtonBackgroundColor = (Color)App.Window.Resources["NativeAccentColor"];
                }
            }
        }
    }
}