namespace KATA
{
    public class PriceCalculator
    {
        public double PriceBeforeTax(Product p) => p.price;

        public double PriceAfterTax(Product prod, int taxRate)
        {
            return PriceBeforeTax(prod) + prod.TaxValue(taxRate);
        }

        public double PriceAfterDiscount(Product prod, double discountRate) => prod.price - prod.DiscountValue(discountRate);

        public object FinalProductPrice(Product product, int discountRate, int taxRate) => PriceAfterTax(product, taxRate) - product.DiscountValue(discountRate);
    }
}