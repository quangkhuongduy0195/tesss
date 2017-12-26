using Xamarin.Forms;
using Views.View;
using System.Diagnostics;

namespace Views.TabItem
{
    public partial class TabABC : ContentPage
    {
        MasterDetailScreen md;
        double widthScreen = 0;
        double heightScreen = 0;
        public TabABC()
        {
            InitializeComponent();
            md = new MasterDetailScreen();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            widthScreen = Application.Current.MainPage.Width;
            heightScreen = Application.Current.MainPage.Height;
            img.HeightRequest = widthScreen / 4;//img1.HeightRequest;
            img.Margin = new Thickness(0, 5, 0, 0);

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                MessagingCenter.Send<TabABC, bool>(this, "Show", true);
            };
            imgMenu.GestureRecognizers.Add(tapGestureRecognizer);


            lbl.WidthRequest = widthScreen * 0.45;
            btn1.WidthRequest = (widthScreen * 0.55) / 3;
            btn2.WidthRequest = (widthScreen * 0.55) / 3;

            lbl2.WidthRequest = widthScreen * 0.25;
            btn3.WidthRequest = widthScreen * 0.2 - 25;
            btn3.Margin = new Thickness(10, 0);
            btn4.WidthRequest = btn4.Height;
            btn5.WidthRequest = btn5.Height;
            et.HorizontalOptions = new LayoutOptions(LayoutAlignment.Fill, true);

            lbl3.WidthRequest = widthScreen * 0.45;
            btn6.WidthRequest = btn6.Height;
            btn7.WidthRequest = btn7.Height;
            et2.HorizontalOptions = new LayoutOptions(LayoutAlignment.Fill, true);
        }
    }
}

