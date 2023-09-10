using MAUIFlyout.POC.Views;

namespace MAUIFlyout.POC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}