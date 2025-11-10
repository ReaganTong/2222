using System.Windows.Input; // Remove Prism.Commands

namespace Lab_2.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ICommand FavoriteCommand { get; }

        public MainPageViewModel()
        {
            // Use the built-in "Command" instead of "DelegateCommand"
            FavoriteCommand = new Command(OnFavorite);
        }

        private async void OnFavorite()
        {
            // This logic is perfect and does not change
            await Application.Current.MainPage.DisplayAlert("Favorite", "You have added this pet to your favorites!", "OK");
        }
    }
}