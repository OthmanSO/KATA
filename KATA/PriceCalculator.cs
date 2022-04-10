using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KATA
{
    public class PriceCalculator
    {
        public double PriceBeforeTax(Product p) => p.price;

        public double PriceAfterTax(Product prod, int taxRate)
        {
            double priceAfterTax = Math.Round(prod.price * (100 + taxRate) / 100, 2, MidpointRounding.AwayFromZero);
            return priceAfterTax;
        }

        public double PriceAfterDiscount(Product prod, double discountRate)
        {
            double priceAfterDiscount = Math.Round(prod.price * (100 - discountRate) / 100, 2, MidpointRounding.AwayFromZero);
            return priceAfterDiscount;
        }
    }
}