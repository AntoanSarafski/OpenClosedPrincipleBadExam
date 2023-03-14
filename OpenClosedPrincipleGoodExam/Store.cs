using OpenClosedPrincipleGoodExam.Promotions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosedPrincipleBadExam
{
    public class Store
    {
        public Store()
        {
            Products = new List<Product>();
        }
        public List<Product> Products { get; set; }

        public void Buy(string productName)
        {
            Product product = Products.FirstOrDefault(p => p.Name == productName);
            List<IPromotion> promotions = new List<IPromotion>()
            {
                new DecemberPromotion(),
                new MondayPromotion(),
                new StValentinePromotion(),
                new SundayPromotion()
            };


            decimal price = product.Price;

            foreach (var promotion in promotions)
            {
                price += promotion.GetPrice(product);
            }
            Console.WriteLine($"Buying {productName} for {price}");
            product.Quantity -= 1;

            // can input much more logic


        }
    }
}
