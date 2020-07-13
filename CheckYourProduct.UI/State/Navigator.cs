using CheckYourProduct.UI.State.Navigators;
using CheckYourProduct.UI.ViewModel;
using System.Windows.Input;

namespace CheckYourProduct.UI.State
{
    public class Navigator : INavigator
    {
        private ProductViewModelBase _currentViewModel;
        public ProductViewModelBase CurrentViewModel 
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
            }
        }

        public ICommand UpdateCurrentViewModelCommand => throw new System.NotImplementedException();
    }
}
