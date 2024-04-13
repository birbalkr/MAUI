using MAUI_App.MVVM.ViewModels;

namespace MAUI_App.MVVM.Views;

public partial class CommandExample : ContentPage
{
	public CommandExample()
	{
		InitializeComponent();
		BindingContext = new CommandViewModel();
	}
}