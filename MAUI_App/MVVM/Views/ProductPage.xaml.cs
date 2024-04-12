using MAUI_App.MVVM.Models;
using MAUI_App.MVVM.ViewModels;

namespace MAUI_App.MVVM.Views;

public partial class ProductPage : ContentPage
{
	public ProductPage()
	{
		InitializeComponent();

		BindingContext = new ProductViewModel();
	}
}