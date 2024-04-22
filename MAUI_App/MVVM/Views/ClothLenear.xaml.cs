using MAUI_App.MVVM.ViewModels;

namespace MAUI_App.MVVM.Views;

public partial class ClothLenear : ContentPage
{
	public ClothLenear()
	{
		InitializeComponent();
		BindingContext = new ClothViewModels();
	}
}