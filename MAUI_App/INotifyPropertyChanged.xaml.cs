namespace MAUI_App;

public partial class INotifyPropertyChanged : ContentPage
{
	Models.Employee emp = new Models.Employee();

	public INotifyPropertyChanged()
	{
		InitializeComponent();

		emp = new Models.Employee()
		{
			Id = 1,
			Name = "Test",
			Age = 1,
		};

		BindingContext = emp;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		emp.Name = "Test2";
		emp.Age = 2;
		emp.Id = 2;
    }
}