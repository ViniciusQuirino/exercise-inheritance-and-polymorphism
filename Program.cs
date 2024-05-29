using System;
using System.Collections.Generic;
using System.Globalization;
using exercise_inheritance_and_polymorphism.Entites;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{(i + 1)} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (c == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (c == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manuFactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manuFactureDate));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product item in list)
            {

                Console.WriteLine(item.PriceTag());
            }
        }
    }
}
