﻿using ProjectTemplate.Mobile.Services.Navigation;
using ProjectTemplate.Mobile.Services.Settings;
using ProjectTemplate.Mobile.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjectTemplate.Mobile.ViewModels
{
    class LoginViewModel : BaseViewModel
    {
        #region constructor
        INavigationService navigationService;
        ISettingsService settingsService;
        public LoginViewModel(INavigationService _navigationService, ISettingsService _settingsService)
        {
            navigationService = _navigationService;
            settingsService = _settingsService;

            Commands.Add("LoginUser", new Command(async () => await LoginUserAsync()));
        }
        #endregion

        #region vmBinabingProps
        private string usernameText;

        public string UsernameText
        {
            get { return usernameText; }
            set { SetProperty(ref usernameText, value); }
        }
        #endregion

        #region vmMethods
        async Task LoginUserAsync()
        {
            if (!string.IsNullOrWhiteSpace(UsernameText))
            {
                settingsService.AuthedUserId = UsernameText;
                await navigationService.NavigateToAsync<HomeViewModel>();
                await navigationService.RemoveBackStackAsync();
            }
        }
        #endregion
    }
}
