using Demo.ViewModels;

namespace Demo.Views;

public partial class Details : ContentPage
{
	public Details(DetailsViewModel detailsViewModel)
	{
		InitializeComponent();
		BindingContext = detailsViewModel;
	}
}