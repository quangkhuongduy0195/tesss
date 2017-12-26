using System.Threading.Tasks;
using Views.TabItem;
using Xamarin.Forms;

namespace Views.View
{
    public partial class MasterDetailScreen : MasterDetailPage
    {
        public MasterDetailScreen()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<TabABC, bool>(this, "Show",(arg1, arg2) => {
                this.IsPresented = true;
            });

            MessagingCenter.Subscribe<TabXYZ, bool>(this, "Show", (arg1, arg2) => {
                this.IsPresented = true;
            });
        }
    }
}

