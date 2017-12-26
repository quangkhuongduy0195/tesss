using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Windows.Input;
using Prism.Navigation;

namespace ViewModels.Save
{
    public class SaveViewModel : ViewModelBase
    {
        private string _text;
        public string mText
        {
            get { return _text; }
            set
            {
                SetProperty(ref _text, value);
            }
        }

        public ICommand btnMainApp { get; }
        INavigationService navigationService;
        public SaveViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            btnMainApp = new DelegateCommand(HandleAction);
        }

        void HandleAction()
        {
            Prism.Common.IPageAware page = (Prism.Common.IPageAware)navigationService;
            page.Page.Navigation.PopToRootAsync();// back root app
        }

        public override void OnNavigatedTo(Prism.Navigation.NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            mText = parameters.GetValue<string>("text");
            Debug.WriteLine(mText);
        }
    }
}
