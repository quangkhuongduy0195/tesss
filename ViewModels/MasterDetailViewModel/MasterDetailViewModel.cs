using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace ViewModels.MasterDetailViewModel
{
    public class MasterDetailViewModel : ViewModelBase
    {
        bool _isShowMenu = false;
        public bool isShowMenu
        {
            get { return _isShowMenu; }
            set
            {
                SetProperty(ref _isShowMenu,value);
            }
        }
        public DelegateCommand CommandShowMenu { get; set; }
        INavigationService navigationService;
        public MasterDetailViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            CommandShowMenu = new DelegateCommand(HandleShowMenu);

            Device.BeginInvokeOnMainThread(async () => {
                await Task.Delay(5000);
                isShowMenu = true;
                //Debug.WriteLine("09182309819283012");
            });
        }

        void HandleShowMenu()
        {
            Debug.WriteLine("09182309819283012");
        }
    }
}
