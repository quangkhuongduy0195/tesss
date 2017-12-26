using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace ViewModels.Order
{
    public class OrderViewModel : ViewModelBase
    {

        public ICommand CommandNext { get; set; }
        private INavigationService navigationService;
        public OrderViewModel(INavigationService navigationService)
        {
            Title = "Please! Login";
            this.navigationService = navigationService;
            CommandNext = new DelegateCommand(handButtonNext);
        }

        public void handButtonNext()
        {
            navigationService.NavigateAsync("info");
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
            }
        }


        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            //await Task.Delay(4000);
            //await navigationService.NavigateAsync("info");
        }

    }
}
