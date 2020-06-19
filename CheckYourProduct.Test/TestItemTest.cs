using CheckYourProduct.UI.ViewModel;
using Domain.Enum;
using Xunit;

namespace CheckYourProduct.Test
{
    public class TestItemTest
    {
        [Fact]
        public void TestItemValid()
        {
            //-- Arrange
            var model = new ProductViewModel();

            //-- Act
            model.Search("3");
            var actual = model.TestItem;

            //-- Assert
            Assert.Equal("Kraftkerni", actual.Name);
            Assert.Equal(Category.Food, actual.Category);
        }
    }
}
