using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectTemplate.Mobile.ViewModels.Base
{
    public class BaseViewModel : ObservableObject
    {
        public Dictionary<string, ICommand> Commands { get; protected set; }

        public virtual async Task OnAppearingAsync() { }
        public virtual async Task OnDisappearingAsync() { }

        public BaseViewModel()
        {
            Commands = new Dictionary<string, ICommand>();
        }

        
        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }

        bool isBusy;
        public bool IsBusy
        {
            get => isBusy;
            set
            {
                if (SetProperty(ref isBusy, value))
                    IsNotBusy = !isBusy;
            }
        }

        bool isNotBusy = true;
        public bool IsNotBusy
        {
            get => isNotBusy;
            set
            {
                if (SetProperty(ref isNotBusy, value))
                    IsBusy = !isNotBusy;
            }
        }


    }
}
