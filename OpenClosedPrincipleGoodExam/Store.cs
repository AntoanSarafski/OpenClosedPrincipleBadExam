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

            if (product == null)
            {
                throw new ArgumentException("Product not found.");
            }

            decimal price = product.Price;
            Console.WriteLine($"Buying {productName} for {price}");
            product.Quantity -= 1;

            // can input much more logic


        }
    }
}
