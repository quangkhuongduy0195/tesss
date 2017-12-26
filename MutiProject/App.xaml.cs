using System.Diagnostics;
using Prism.Unity;
using ViewModels.Info;
using ViewModels.Order;
using Views.View;
using ViewModels.Save;
using ViewModels.MasterDetailViewModel;
using Xamarin.Forms;

namespace MutiProject
{
    public partial class App : PrismApplication
    {

        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("materDetail/root/order");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>("root");
            Container.RegisterTypeForNavigation<InfoScreen, InfoViewModel>("info");
            Container.RegisterTypeForNavigation<OrderScreen, OrderViewModel>("order");
            Container.RegisterTypeForNavigation<SaveScreen, SaveViewModel>("save");
            Container.RegisterTypeForNavigation<MasterDetailScreen, MasterDetailViewModel>("materDetail");
        }

        

    }
}
