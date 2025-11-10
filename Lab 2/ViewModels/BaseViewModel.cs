using Prism.Mvvm;

namespace Lab_2.ViewModels
{
    public abstract class BaseViewModel : BindableBase
    {
        // By inheriting BindableBase, Fody will automatically
        // handle the INotifyPropertyChanged implementation
    }
}