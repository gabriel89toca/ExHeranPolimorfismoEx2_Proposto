using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeranPolimorfismoEx2_Proposto.Entities
{
    internal class Product
    {
        public String Name { get; set; }
        public Double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual String PriceTag() {
            return " $ " + Price.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
