using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using MyLabApp.ViewModels;
using MyLabApp.Views;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;

namespace MyLabApp
{
    public partial class App : PrismApplication
    {
        public App() : this(null) { }
        
        public App(IPlatformInitializer initializer) : base(initializer) { }
        
        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(BlankView)}");
        }
        
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<BlankView, BlankViewModel>();
        }

        protected override void OnStart()
        {
            base.OnStart();

            AppCenter.Start($"android={AppSecrets.App_Center_Android_Key};" +
                            $"ios={AppSecrets.App_Center_Ios_Key};",
                typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
