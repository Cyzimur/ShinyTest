using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ShinyTest.Services;
using ShinyTest.Views;
using Prism;
using Prism.Ioc;
using ShinyTest.ViewModels;

namespace ShinyTest
{
    public partial class App : PrismApplication
    {

        public App() { }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<AboutPage, AboutViewModel>("AboutPage");
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            Xamarin.Forms.Device.SetFlags(new string[] { "Shapes_Experimental" });

            await NavigationService.NavigateAsync("AboutPage");
            if (Xamarin.Forms.Device.RuntimePlatform == Xamarin.Forms.Device.iOS)
                Resources.Add(new Style(typeof(Frame))
                {
                    Setters =
                    {
                        new Setter { Property = Frame.HasShadowProperty, Value = false },
                        new Setter { Property = Frame.CornerRadiusProperty, Value = 0 }
                    }
                });
        }
    }
}
