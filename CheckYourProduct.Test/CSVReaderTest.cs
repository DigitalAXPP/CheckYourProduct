using Product.Data;
using Xunit;

namespace CheckYourProduct.Test
{
    public class CSVReaderTest
    {
        [Fact]
        public void ReadTest()
        {
            //-- Arrange
            var csv = new CSVReader();

            //-- Act
            var coll = csv.Read();

            //-- Assert
            Assert.NotNull(coll);
        }
    }
}
