using ProjectTemplate.Mobile.Services.Navigation;
using ProjectTemplate.Mobile.Services.Settings;
using ProjectTemplate.Mobile.Services.User;
using ProjectTemplate.Mobile.ViewModels.Base;
using ProjectTemplate.Shared.Models;
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
        public IUserService userService { get; set; }
        public HomeViewModel(INavigationService _navigationService, IUserService _userService)
        {
            navigationService = _navigationService;
            userService = _userService;
            Commands.Add("LogoutUser", new Command(async () => await LogoutUserAsync()));
            Commands.Add("ChangeName", new Command(() => ChangeName()));
        }

        public override Task OnAppearingAsync()
        {
            return base.OnAppearingAsync();
        }

        #region vmProperties
        

        #endregion


        #region vmMethods
        void ChangeName()
        {
            userService.LoggedOnUser.Username = "Hello World";
        }
        async Task LogoutUserAsync()
        {
            userService.Logout();
            await navigationService.NavigateToAsync<LoginViewModel>();
        }
        #endregion
    }
}
