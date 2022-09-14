using System;
using System.Collections.Generic;
using System.Globalization;
using HerancaPolimorfismo.Entities;

namespace HerancaPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>(); 

            Console.WriteLine("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());  

            for(int i = 1; i <= n; i++)
            {
                Console.Write($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Price $: ");
                double price = double.Parse(Console.ReadLine());  
                
                if(ch == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if(ch == 'u')
                {
                    Console.Write("Manufacture Date (DD/MM/YYYY: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));

                }

                else 
                 {
                    Console.Write("Customs fee: "); 
                    double customsFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));   
                 } 
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach(Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
