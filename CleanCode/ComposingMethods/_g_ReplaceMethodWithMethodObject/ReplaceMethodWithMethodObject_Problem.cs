using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.ComposingMethods._g_ReplaceMethodWithMethodObject
{
    class ReplaceMethodWithMethodObject_Problem
    {
		class Order
		{
			public double price()
			{
				double primaryBasePrice = 1;
				double secondaryBasePrice = 1;
				double tertiaryBasePrice = 1;
				// Perform long computation.

				return tertiaryBasePrice * secondaryBasePrice * primaryBasePrice;
			}
		}
	}
}
