using CheckYourProduct.UI.State.Navigators;
using CheckYourProduct.UI.ViewModel;
using System;
using System.Windows.Input;

namespace CheckYourProduct.UI.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private INavigator _navigator;
        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewType)
            {
                ViewType type = (ViewType)parameter;
                switch (type)
                {
                    case ViewType.SearchPage:
                        _navigator.CurrentViewModel = new SearchViewModel();
                        break;
                    case ViewType.ResultPage:
                        _navigator.CurrentViewModel = new ResultViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
