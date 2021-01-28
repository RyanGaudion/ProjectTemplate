using ProjectTemplate.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTemplate.Mobile.Services.User
{
    public interface IUserService
    {
        Person LoggedOnUser { get; set; }
        bool Login(string username, string password);
        void Logout();
    }
}
