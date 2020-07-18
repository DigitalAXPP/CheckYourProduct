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
        public void StateToSearchPageTest()
        {
            //-- Arrange
            var currentViewModel = (ProductViewModelBase)new ProductViewModel();
            var nav = new Navigator();
            nav.CurrentViewModel = currentViewModel;

            //-- Act
            var updateNavBase = new UpdateCurrentViewModelCommand(nav);
            updateNavBase.Execute(ViewType.SearchPage);

            //-- Assert
            Assert.IsType<SearchViewModel>(nav.CurrentViewModel);
        }

        [Fact]
        public void StateToResultPageTest()
        {
            //-- Arrange
            var currentViewModel = (ProductViewModelBase)new ProductViewModel();
            var nav = new Navigator();
            nav.CurrentViewModel = currentViewModel;

            //-- Act
            var updateNavBase = new UpdateCurrentViewModelCommand(nav);
            updateNavBase.Execute(ViewType.ResultPage);

            //-- Assert
            Assert.IsType<ResultViewModel>(nav.CurrentViewModel);
        }
    }
}
