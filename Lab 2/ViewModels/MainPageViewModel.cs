using Prism.Commands;
using System.Windows.Input;

namespace Lab_2.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        // This will replace your "OnFavoriteClicked" method
        public ICommand FavoriteCommand { get; }

        public MainPageViewModel()
        {
            // This connects the ICommand to a method in this file
            FavoriteCommand = new DelegateCommand(OnFavorite);
        }

        private async void OnFavorite()
        {
            // This is your exact logic from MainPage.xaml.cs
            // We use Application.Current.MainPage to access DisplayAlert from a ViewModel
            await Application.Current.MainPage.DisplayAlert("Favorite", "You have added this pet to your favorites!", "OK");
        }
    }
}