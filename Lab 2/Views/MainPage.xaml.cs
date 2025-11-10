namespace Lab_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnFavoriteClicked(object sender, EventArgs e)
        {
            
            DisplayAlert("Favorite", "You have added this pet to your favorites!", "OK");
        }
    }
}