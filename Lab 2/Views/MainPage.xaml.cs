using Lab_2.ViewModels; // <-- ADD THIS

namespace Lab_2.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // This is the most important step:
            BindingContext = new MainPageViewModel();
        }
    }
}