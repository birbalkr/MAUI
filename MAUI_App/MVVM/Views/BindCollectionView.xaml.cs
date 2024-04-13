using MAUI_App.MVVM.ViewModels;

namespace MAUI_App.MVVM.Views;

public partial class BindCollectionView : ContentPage
{
	public BindCollectionView()
	{
		InitializeComponent();
		BindingContext = new ProductViewCollection();
	}
}