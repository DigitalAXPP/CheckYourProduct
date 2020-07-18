using CheckYourProduct.UI.Commands;
using CheckYourProduct.UI.State;
using CheckYourProduct.UI.State.Navigators;
using CheckYourProduct.UI.ViewModel;
using Xunit;

namespace CheckYourProduct.Test
{
    public class ViewModelTest
    {
        [Fact]
        public void StateTest()
        {
            //-- Arrange
            var currentViewModel = (ProductViewModelBase)new ProductViewModel();
            var nav = new Navigator();
            nav.CurrentViewModel = currentViewModel;
            //var updateVM = new UpdateCurrentViewModelCommand(nav);

            //-- Act
            var updateNavBase = new UpdateCurrentViewModelCommand(nav);
            updateNavBase.Execute(ViewType.SearchPage);

            //-- Assert
        }
    }
}
