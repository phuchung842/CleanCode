using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.ComposingMethods._g_ReplaceMethodWithMethodObject
{
    class ReplaceMethodWithMethodObject_Solution
    {
		class Order
		{
			// ...
			public double price()
			{
				return new PriceCalculator(this).compute();
			}
		}
		class PriceCalculator
		{
			private double primaryBasePrice;
			private double secondaryBasePrice;
			private double tertiaryBasePrice;
			public PriceCalculator(Order order)
			{
				// Copy relevant information from the
				// order object.
			}

			public double compute()
			{
				return primaryBasePrice * secondaryBasePrice * tertiaryBasePrice;
				// Perform long computation.
			}
		}
	}
}
