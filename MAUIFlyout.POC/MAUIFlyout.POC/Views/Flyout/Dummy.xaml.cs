using MAUIFlyout.POC.Utils;

namespace MAUIFlyout.POC.Views.Flyout;

public partial class Dummy : ContentPage
{
	public Dummy()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("/MainPageDetail");
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        MiscUtils.SetFlyoutItem("MainPage");
    }
}