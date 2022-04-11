using FluentAssertions;
using KATA;
using Xunit;

namespace Price_Calculator_Testing
{
    public class GenericUpcCalculator { }
    public class UnitTest1
    {
        [Theory]
        [InlineData("The Little Prince", 12345, 20.25)]
        public void PriceBeforTax_InputProduct_ReturnDoublePrice(string name, int UPC, double price)
        {
            PriceCalculator pc = new PriceCalculator();
            var prod = GenerateProduct(name, UPC, price);
            double actual = pc.PriceBeforeTax(prod);
            var expected = 20.25;
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(20, 24.30, "The Little Prince", 12345, 20.25)]
        [InlineData(21, 24.50, "The Little Prince", 12345, 20.25)]
        public void PriceAfterTax_InputProduct_ReturnDoublePrice(int taxRate, double expected, string name, int UPC, double price)
        {
            PriceCalculator pc = new PriceCalculator();
            var prod = GenerateProduct(name, UPC, price);
            double actual = pc.PriceAfterTax(prod, taxRate);
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(15, 17.21, "The Little Prince", 12345, 20.25)]
        public void PriceAfterDiscount_InputProduct_outputDoublePriceAfterDiscount(int discountRate, double expected, string name, int UPC, double price)
        {
            var pc = new PriceCalculator();
            var product = GenerateProduct(name, UPC, price);
            var actual = pc.PriceAfterDiscount(product, discountRate);
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(20, 15, 21.26, "The Little Prince", 12345, 20.25)]
        public void PriceAfterTaxAndDiscount_InputProduct_outputDoublePriceAfterTaxAndDiscount(int taxRate, int discountRate, double expected, string name, int UPC, double price)
        {
            var pc = new PriceCalculator();
            var product = GenerateProduct(name, UPC, price);
            var actual = pc.FinalProductPrice(product, discountRate, taxRate);
            actual.Should().Be(expected);
        }

        private Product GenerateProduct(string Name, int UPC, double price)
        {
            return new Product(Name, UPC, price);
        }
    }
}