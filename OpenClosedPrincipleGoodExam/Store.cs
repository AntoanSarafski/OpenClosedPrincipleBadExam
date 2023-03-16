using OpenClosedPrincipleGoodExam.Promotions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosedPrincipleBadExam
{
    public class Store
    {
        private List<IPromotion> promotions;

        public Store(List<IPromotion> promotions)
        {
            Products = new List<Product>();

            this.promotions = promotions;
        }
        public List<Product> Products { get; set; }

        public void Buy(string productName)
        {
            Product product = Products.FirstOrDefault(p => p.Name == productName);
            
            decimal price = product.Price;

            foreach (var promotion in promotions)
            {
                price -= promotion.GetPrice(product);
            }
            Console.WriteLine($"Buying {productName} for {price}");
            product.Quantity -= 1;

            // can input much more logic


        }
    }
}
