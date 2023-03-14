using OpenClosedPrincipleBadExam;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrincipleGoodExam.Promotions
{
    public interface IPromotion
    {
        decimal GetPrice(Product product);
    }
}
