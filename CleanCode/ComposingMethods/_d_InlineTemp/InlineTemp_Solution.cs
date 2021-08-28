using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.ComposingMethods._d_InlineTemp
{
    class InlineTemp_Solution
    {
        private bool hasDiscount(Order order)
        {
            return order.basePrice() > 1000;
        }
    }
}
