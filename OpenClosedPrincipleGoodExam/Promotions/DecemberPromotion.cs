using OpenClosedPrincipleBadExam;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrincipleGoodExam.Promotions
{
    public class DecemberPromotion : IPromotion
    {
        public decimal GetPrice(Product product)
        {
            decimal result = 0;

            if (DateTime.Now.Month == 12 && product.Quantity > 50)
            {
                result -= product.Price * 0.5m;
                Console.WriteLine("Final sale! Yay :)");
            }

            return result;
        }
    }
}
