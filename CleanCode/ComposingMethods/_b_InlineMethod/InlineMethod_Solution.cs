using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.ComposingMethods._b_InlineMethod
{
    class InlineMethod_Solution
    {
        int numberOfLateDeliveries;
        int getRating()
        {
            return numberOfLateDeliveries > 5 ? 2 : 1;
        }
    }
}
