namespace MAUIFlyout.POC.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new AppShell();
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await App.Current.MainPage.Navigation.PushAsync(new ForgotPassword());
    }
}