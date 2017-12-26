using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware
    {
        //protected INavigationService _navigationService { get; }
        //public ViewModelBase(INavigationService _navigationService)
        //{
        //    this._navigationService = _navigationService;
        //}

        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }

        public virtual void OnNavigatingTo(NavigationParameters parameters)
        {
        }
    }
}
