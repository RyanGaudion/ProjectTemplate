using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTemplate.Mobile.Services.Dependency
{
    public interface IDependencyService
    {
        T Get<T>() where T : class;
    }
}
