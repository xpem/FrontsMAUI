using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MAUIBank.ViewModels
{
    public partial class PinPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string pin = string.Empty;

        public PinPageViewModel()
        {
        }

        [RelayCommand]
        private async Task KeyboardButtonClicked(string parameter, CancellationToken cancellationToken)
        {
            Pin += parameter;
            switch (Pin.Length)
            {
                case < 4:
                    break;
                default:
                    await ValidatePin(cancellationToken);
                    break;
            }
        }

        private async Task ValidatePin(CancellationToken cancellationToken)
        {
            const string userPin = "1111";
            if (Pin == userPin)
            {
                await GetMainPage().GoToAsync("//home");
            }
            else
            {
                await CommunityToolkit.Maui.Alerts.Toast.Make("Pin is not valid").Show(cancellationToken);
            }

            Pin = string.Empty;
        }

        private AppShell GetMainPage()
        {
            ArgumentNullException.ThrowIfNull(Application.Current?.MainPage);
            return (AppShell)Application.Current.MainPage;
        }
    }
}
