using MAUI_App.MVVM.ViewModels;

namespace MAUI_App.MVVM.Views;

public partial class ClothPage : ContentPage
{
	public ClothPage()
	{
		InitializeComponent();
		BindingContext = new ClothViewModels();
	}
}