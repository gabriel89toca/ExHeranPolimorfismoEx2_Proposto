using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExHeranPolimorfismoEx2_Proposto.Entities
{
    internal class ImportedProduct : Product
    {
        public Double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base (name,  price)
        {
            CustomsFee = customsFee;
        }

        public Double TotalPrice()
        {
            return CustomsFee + base.Price;
        }

        public override string PriceTag()
        {
            return " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ").";
        }
    }
}
