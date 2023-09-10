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
    }
}