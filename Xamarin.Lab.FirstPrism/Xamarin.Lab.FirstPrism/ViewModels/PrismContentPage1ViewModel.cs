using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Xamarin.Lab.FirstPrism.ViewModels
{
    public class PrismContentPage1ViewModel : ViewModelBase
    {
        public PrismContentPage1ViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            this.Title = "456";
        }
    }
}
