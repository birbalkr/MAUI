using System.Diagnostics;

namespace MAUI_App;

public partial class InputControls : ContentPage
{
	public InputControls()
	{
		InitializeComponent();
	}

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        resultSlider.Text= Slider.Value.ToString();
    }

    private void stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if(stepper1!=null) { resultSlider.Text = stepper1.Value.ToString(); }
    }

    private void UserTxt_TextChanged(object sender, TextChangedEventArgs e)
    {
        
        Debug.WriteLine(UserTxt.Text);
    }

    private void UserTxt_Completed(object sender, EventArgs e)
    {

    }
}