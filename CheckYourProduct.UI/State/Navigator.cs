using CheckYourProduct.UI.State.Navigators;
using CheckYourProduct.UI.ViewModel;
using System.Windows.Input;

namespace CheckYourProduct.UI.State
{
    public class Navigator : INavigator
    {
        public ProductViewModelBase CurrentViewModel { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public ICommand UpdateCurrentViewModelCommand => throw new System.NotImplementedException();
    }
}
