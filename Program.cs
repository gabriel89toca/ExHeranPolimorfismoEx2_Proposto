using ExHeranPolimorfismoEx2_Proposto.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ExHeranPolimorfismoEx2_Proposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Common, used or imported(c/ u / i)?");
                Char typeProduct = Char.Parse(Console.ReadLine());
                Console.WriteLine("Product #{i} data:");
                Console.Write("Name:");
                string productName = Console.ReadLine();
                Console.Write("Price:");
                Double productPrice = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (typeProduct == 'c')
                {

                    products.Add(new Product(productName, productPrice));

                }
                else if (typeProduct == 'u')
                {
                    Console.Write("Manufacture date(DD/ MM / YYYY):");
                    DateOnly Mdate = DateOnly.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(productName, productPrice, Mdate));
                }
                else
                {
                    Console.Write("Customs fee:");
                    Double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(productName, productPrice, customsFee));

                }


            }

            Console.WriteLine("PRICE TAGS:");
            Console.WriteLine("");
            
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name + product.PriceTag());
            }


        }



    }
}