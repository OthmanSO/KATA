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
        [Fact]
        public void PriceAfterTax_InputProduct_ReturnDoublePrice()
        {
            PriceCalculator pc = new PriceCalculator();
            var prod = GenerateProduct("The Little Prince", 12345, 20.25);
            double actual = pc.PriceAfterTax(prod, 20); 
            var expected = 24.30;
            Assert.Equal(expected, actual);
        }

        private Product GenerateProduct(string Name, int UPC, double price)
        {
            return new Product(Name,UPC,price);
        }
    }
}