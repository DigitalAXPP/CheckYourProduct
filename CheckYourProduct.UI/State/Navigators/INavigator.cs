using CheckYourProduct.UI.ViewModel;
using System.Windows.Input;

namespace CheckYourProduct.UI.State.Navigators
{
    public interface INavigator
    {
        ProductViewModelBase CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
