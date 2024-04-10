using MAUI_App.Models;

namespace MAUI_App;

public partial class DataBinding : ContentPage
{
	public DataBinding()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        MAUI_App.Models.Employee emp = new MAUI_App.Models.Employee()
        {
            Id = 1,
            Name = "Aditya",
            Age = 20
            
        };

        Binding empBinding = new Binding();
        empBinding.Source = emp;
        empBinding.Path = "Name";

        EmployeeLbl.SetBinding(Label.TextProperty, empBinding);


    }
}