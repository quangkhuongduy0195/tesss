using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using System.Windows.Input;
using System.Diagnostics;

namespace ViewModels.Info
{
    public class InfoViewModel : ViewModelBase
    {
        private INavigationService navigationService;
        public InfoViewModel(INavigationService navigationService)
        {
            Title = "Info screen";
            this.navigationService = navigationService;
            btnSave = new DelegateCommand<string>(HandleActionButtonSave);
        }

        public ICommand btnSave { get; set; }

        void HandleActionButtonSave(string text)
        {
            Debug.WriteLine(text);
            var pr = new NavigationParameters();
            pr.Add("text", text);
            navigationService.NavigateAsync("save", pr);
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
    }
}
