using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTemplate.Mobile.Services.Dependency
{
    class DependencyService : IDependencyService
    {
        public T Get<T>() where T : class
        {
            return Xamarin.Forms.DependencyService.Get<T>();
        }
    }
}
