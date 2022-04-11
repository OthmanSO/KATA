namespace KATA
{
    public class PriceCalculator
    {
        public double PriceBeforeTax(Product p) => p.price;

        public double TaxAmount(Product prod, int taxRate) => prod.TaxValue(taxRate);


        public double DiscountAmount(Product prod, double discountRate) => prod.DiscountValue(discountRate);

        public object FinalProductPrice(Product product, int discountRate, int taxRate) => PriceBeforeTax(product) + TaxAmount(product, taxRate) - DiscountAmount(product,discountRate);

        public object ReportFinalProductPriceAndDiscountamount(Product product, int discountRate, int taxRate)
            => $"Price = ${this.FinalProductPrice(product, discountRate, taxRate)}, Discount amount = ${DiscountAmount(product,discountRate)}";
    }
}