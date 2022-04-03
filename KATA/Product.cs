using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
