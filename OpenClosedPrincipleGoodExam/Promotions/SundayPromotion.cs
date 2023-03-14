using OpenClosedPrincipleBadExam;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrincipleGoodExam.Promotions
{
    public class SundayPromotion : IPromotion
    {
        public decimal GetPrice(Product product)
        {
            decimal result = 0;

            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                result -= product.Price * 0.5m;
                Console.WriteLine("50% off because it is Monday! Yaay!");
            }
            return result;
        }
    }
}
