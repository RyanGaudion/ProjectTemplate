using ProjectTemplate.Mobile.Services.Navigation;
using ProjectTemplate.Mobile.ViewModels.Base;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectTemplate.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.UWP)
                InitNavigation();
        }

        private Task InitNavigation()
        {
            INavigationService navigationService = ViewModelLocator.Resolve<INavigationService>();
            return navigationService.InitializeAsync();
        }
        protected override void OnStart()
        {
            if (Device.RuntimePlatform != Device.UWP)
                InitNavigation();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
