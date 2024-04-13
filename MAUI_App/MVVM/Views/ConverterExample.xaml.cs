using MAUI_App.MVVM.ViewModels;

namespace MAUI_App.MVVM.Views;

public partial class ConverterExample : ContentPage
{
	public ConverterExample()
	{
		InitializeComponent();

		BindingContext = new PersonViewModel();
	}
}