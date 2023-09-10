namespace MAUIFlyout.POC.Views.Flyout;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("/MainPageDetail");
    }
}