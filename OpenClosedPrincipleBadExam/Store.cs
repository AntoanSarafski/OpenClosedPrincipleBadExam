using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosedPrincipleBadExam
{
    public class Store
    {
        public List<Product> Products { get; set; }

        public void Buy(string productName)
        {
            Product product = Products.FirstOrDefault(p => p.Name == productName);

            if (product == null)
            {
                throw new ArgumentException("Product not found.")
            }
        }
    }
}
