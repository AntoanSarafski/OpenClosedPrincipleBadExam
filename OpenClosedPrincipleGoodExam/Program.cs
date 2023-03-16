using OpenClosedPrincipleBadExam;
using OpenClosedPrincipleGoodExam.Promotions;
using System;
using System.Collections.Generic;

namespace OpenClosedPrincipleGoodExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(new List<IPromotion>()
            {
                new MondayPromotion(),
                new SundayPromotion(),
                new StValentinePromotion(),
                new DecemberPromotion()

            });

            store.Products.Add(new Product()
            {
                Name = "T-shirt",
                Price = 100,
                Quantity = 60
            });

            store.Products.Add(new Product()
            {
                Name = "Shoes",
                Price = 200,
                Quantity = 60
            });

            store.Products.Add(new Product()
            {
                Name = "Jeans",
                Price = 400,
                Quantity = 14
            });

            while (true)
            {
                Console.WriteLine("What do you want to buy?");
                string productName = Console.ReadLine();

                store.Buy(productName);
            }

        }
    }
}
