using Xunit;
using KATA;

namespace Price_Calculator_Testing
{
    public class UnitTest1
    {
        [Fact]
        public void PriceBeforTax_InputProduct_ReturnDoublePrice()
        {
            PriceCalculator pc = new PriceCalculator();
            var prod = GenerateProduct("The Little Prince",12345, 20.25 );
            double actual = pc.PriceBeforeTax(prod);
            var expected = 20.25;
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(20, 24.30)]
        [InlineData(21, 24.50)]
        public void PriceAfterTax_InputProduct_ReturnDoublePrice(int taxRate , double expected)
        {
            PriceCalculator pc = new PriceCalculator();
            var prod = GenerateProduct("The Little Prince", 12345, 20.25);
            double actual = pc.PriceAfterTax(prod, taxRate); 
            Assert.Equal(expected, actual);
        }

        private Product GenerateProduct(string Name, int UPC, double price)
        {
            return new Product(Name,UPC,price);
        }
    }
}