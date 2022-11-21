using MAUIBank.ViewModels;

namespace MAUIBank.Views;

public partial class PinPage : ContentPage
{
	public PinPage(PinPageViewModel pinPageViewModel)
	{
		InitializeComponent();
		BindingContext = pinPageViewModel;
	}
}