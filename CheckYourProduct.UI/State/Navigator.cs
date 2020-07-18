using CheckYourProduct.UI.Commands;
using CheckYourProduct.UI.Model;
using CheckYourProduct.UI.State.Navigators;
using CheckYourProduct.UI.ViewModel;
using System.Windows.Input;

namespace CheckYourProduct.UI.State
{
    public class Navigator : ObservableObjects, INavigator
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
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
    }
}
