namespace KATA
{
    public class Product
    {
        private string name;
        private int UPC;
        public double price;


        public Product(string name, int UPC, double price)
        {
            this.name = name;
            this.UPC = UPC;
            this.price = price;
        }

        internal double TaxValue(int taxRate) => Math.Round(this.price * taxRate / 100, 2, MidpointRounding.AwayFromZero);

        internal double DiscountValue(double discountRate) => Math.Round(this.price * discountRate / 100, 2, MidpointRounding.AwayFromZero);
    }
}
