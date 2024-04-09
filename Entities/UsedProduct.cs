using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeranPolimorfismoEx2_Proposto.Entities
{
    internal class UsedProduct : Product
    {
        public DateOnly ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateOnly manufactureDate) : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return "(Used) " + base.PriceTag() + " (Manufacture Date: " + ManufactureDate.ToString("dd/MM/yyyy") + ").";
        }
    }
}
