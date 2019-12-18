using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Xamarin.Lab.FirstPrism.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ICommand Go { get; set; } 
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.Go = new DelegateCommand(() =>
            {
                this.NavigationService.NavigateAsync("NavigationPage/PrismContentPage1");
 
          });
            Title = "我是Main Page123";
        }
    }
}
