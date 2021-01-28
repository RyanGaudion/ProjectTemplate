using ProjectTemplate.Mobile.Services.Navigation;
using ProjectTemplate.Mobile.Services.Settings;
using ProjectTemplate.Mobile.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjectTemplate.Mobile.ViewModels
{
    class HomeViewModel : BaseViewModel
    {
        INavigationService navigationService;
        ISettingsService settingsService;
        public HomeViewModel(INavigationService _navigationService, ISettingsService _settingsService)
        {
            navigationService = _navigationService;
            settingsService = _settingsService;

            Commands.Add("LogoutUser", new Command(async () => await LogoutUserAsync()));
        }

        #region vmMethods
        async Task LogoutUserAsync()
        {
            //Remove user from settings
            await navigationService.NavigateToAsync<LoginViewModel>();
        }
        #endregion
    }
}
