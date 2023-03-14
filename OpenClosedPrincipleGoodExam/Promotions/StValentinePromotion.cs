using OpenClosedPrincipleBadExam;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrincipleGoodExam.Promotions
{
    public class StValentinePromotion : IPromotion
    {
        public decimal GetPrice(Product product)
        {
            decimal result = 0;

            if (DateTime.Now.Month == 2 && DateTime.Now.Day == 14)
            {
                result += product.Price * 0.3m;
                Console.WriteLine("30% up because it is St. Valentine! Ouch ! Why you wait until last minute ??? :( ");
            }
            return result;
        }
    }
}
