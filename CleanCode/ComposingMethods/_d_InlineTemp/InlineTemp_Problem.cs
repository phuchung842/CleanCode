using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.ComposingMethods._d_InlineTemp
{
    //You have a temporary variable 
    //that's assigned the result of a simple expression and nothing more.
    class InlineTemp_Problem
    {
        bool hasDiscount(Order order)
        {
            double basePrice = order.basePrice();
            return basePrice > 1000;
        }
    }
}
