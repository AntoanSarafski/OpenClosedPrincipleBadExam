using OpenClosedPrincipleBadExam;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrincipleGoodExam.Promotions
{
    public class MondayPromotion : IPromotion
    {
        public decimal GetPrice(Product product)
        {
            decimal result = 0;

            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                result -= product.Price * 0.2m;
                Console.WriteLine("20% off because it is Monday! Yaay!");
            }
            return result;
        }
    }
}
