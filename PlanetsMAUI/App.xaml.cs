using PlanetsMAUI.Views;

namespace PlanetsMAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new StartPage();
	}
}
