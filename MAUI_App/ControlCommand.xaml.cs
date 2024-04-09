namespace MAUI_App;

public partial class ControlCommand : ContentPage
{
	public ControlCommand()
	{
		InitializeComponent();
	}

    private void Butt_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Demo page", "Hello", "ok");
    }

    private void ImgButt_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Demo page", "Hello Img", "ok");
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        DisplayAlert("Demo page", $"{ e.Value}", "ok");
    }

    private void Search_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Searching", $"you search {Search.Text}", "ok");
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {

    }
}