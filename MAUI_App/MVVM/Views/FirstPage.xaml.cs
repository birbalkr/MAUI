using Plugin.Fingerprint.Abstractions;

namespace MAUI_App.MVVM.Views;

public partial class FirstPage : ContentPage
{
    private readonly IFingerprint fingerprint;

	public FirstPage(IFingerprint fingerprint)
	{
		InitializeComponent();
        this.fingerprint = fingerprint;
	}

   

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SecondPage(nametxt.Text));
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ThirdPage());

    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        var request = new AuthenticationRequestConfiguration("Finger's validate","For Access");
        var result = await fingerprint.AuthenticateAsync(request);
        if (result.Authenticated)
        {
            await DisplayAlert("Authenticated", "Access Granted", "ok");
        }
        else
        {
            await DisplayAlert("Authenticated", "Access Denied", "ok");
        }
    }
}