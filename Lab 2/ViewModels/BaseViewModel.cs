using System.ComponentModel; // Change this from Prism.Mvvm

namespace Lab_2.ViewModels
{
    // Just implement the interface. 
    // Fody will automatically add the PropertyChanged event.
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}