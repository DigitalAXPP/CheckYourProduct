using CheckYourProduct.UI.ViewModel;
using System;
using System.Windows.Input;

namespace CheckYourProduct.UI.Commands
{
    public class SearchKeyword : ICommand
    {
        private ProductViewModel productViewModel;
        public event EventHandler CanExecuteChanged;

        public SearchKeyword(ProductViewModel pvw)
        {
            productViewModel = pvw;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            productViewModel.Search();
        }
    }
}
