using ViewModels.MasterDetailViewModel;
using Xamarin.Forms;

namespace Views.TabItem
{
    public partial class TabXYZ : ContentPage
    {
        public TabXYZ()
        {
            InitializeComponent();
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                MessagingCenter.Send<TabXYZ, bool>(this, "Show", true);
            };
            imgMenu.GestureRecognizers.Add(tapGestureRecognizer);
        }
    }
}

