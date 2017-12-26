using System.Diagnostics;
using Xamarin.Forms;
using ViewModels.Order;
using Naxam.Controls.Forms;

namespace Views.View
{
    public partial class OrderScreen
    {
        public OrderScreen()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        //public OrderViewModel ViewModel
        //{
        //    get { return BindingContext as OrderViewModel; }
        //}

        void Handle_CurrentPageChanged(object sender, System.EventArgs e)
        {
            //int indexTab = this.Children.IndexOf(this.CurrentPage);
            //var tabName = this.Children[indexTab];
            //Debug.WriteLine("=========Handle_CurrentPageChanged=========="+  tabName.Title );
        }

    }
}

