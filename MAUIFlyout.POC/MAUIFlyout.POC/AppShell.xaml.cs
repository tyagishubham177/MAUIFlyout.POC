using MAUIFlyout.POC.Utils;
using MAUIFlyout.POC.Views;

namespace MAUIFlyout.POC
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("MainPage/MainPageDetail", typeof(MainPageDetail));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MiscUtils.SetFlyoutItem("MainPage");
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            MiscUtils.SetFlyoutItem("Profile");
        }
    }
}