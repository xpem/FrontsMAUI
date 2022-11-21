using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUIBank.Models;
using System.Windows.Input;

namespace MAUIBank.ViewModels
{
    public partial class CardPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string[] pages = { "1","2" };
        [ObservableProperty]
        private string currentPage = "1";
        [ObservableProperty]
        private List<Reward> rewards = new();
        [ObservableProperty]
        private List<TransactionGroup> transactions;

        [ObservableProperty]
        private bool isBackMode;

        [ObservableProperty]
        private string bankName;

        [ObservableProperty]
        private bool isFrontMode;


        public CardPageViewModel()
        {
            List<Transaction> transactionsList = new();

            for (int i = 0; i < 60; i++)
            {
                rewards.Add(new Reward()
                {
                    IsAchieved = Random.Shared.Next(0, 10) > 5,
                    Image = "https://picsum.photos/50",
                    Text = $"Reward {i}"
                });

                transactionsList.Add(new Transaction()
                {
                    DateTime = new DateTime(DateTime.Now.Year - 1, Random.Shared.Next(1, 12), Random.Shared.Next(1, 28), Random.Shared.Next(0, 12), Random.Shared.Next(0, 59), Random.Shared.Next(0, 59)),
                    Name = "Andrew",
                    Description = "Send to card",
                    Sum = $"{Random.Shared.Next(-1000, 1000) + Math.Round(Random.Shared.NextSingle(), 2)}$"
                });

            }

            transactions = transactionsList.OrderByDescending(x => x.DateTime)
                                           .GroupBy(x => x.DateTime.Date)
                                           .Select(tr => new TransactionGroup(tr.Key, tr.ToList()))
                                           .ToList();

            IsFrontMode= true;
            IsBackMode = false;
            BankName = "Bank Name";
        }

        public ICommand SwitchModeCommand => new Command((e) => { ChangeSideCard(); });

        void ChangeSideCard()
        {
            IsBackMode = !IsBackMode;
            IsFrontMode = !IsFrontMode;
        }

        [RelayCommand]
        private Task More()
        {
            return GetMainPage().GoToAsync("//home/profile", true);
        }

        private AppShell GetMainPage()
        {
            ArgumentNullException.ThrowIfNull(Application.Current?.MainPage);
            return (AppShell)Application.Current.MainPage;
        }
    }
}
