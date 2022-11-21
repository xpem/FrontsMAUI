using MAUIBank.ViewModels;

namespace MAUIBank.Views;

public partial class CardPage : ContentPage
{
	public CardPage(CardPageViewModel cardPageViewModel)
	{
		InitializeComponent();
		BindingContext = cardPageViewModel;
	}
}