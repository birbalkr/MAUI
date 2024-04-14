namespace MAUI_App.MVVM.Views;

public partial class SecondPage : ContentPage
{
	public SecondPage(string name)
	{
		InitializeComponent();
        UserText.Text = name;
	}
    protected override bool OnBackButtonPressed()
    {
        return true;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ThirdPage());
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}