namespace MAUIFlyout.POC.Views;

public partial class ForgotPassword : ContentPage
{
	public ForgotPassword()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await App.Current.MainPage.Navigation.PopAsync();
    }
}