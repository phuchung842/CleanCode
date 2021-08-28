using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.ComposingMethods._b_InlineMethod
{
    //When a method body is more obvious than the method itself, use this technique.
    public class InlineMethod_Problem
    {
		int numberOfLateDeliveries;
		int getRating()
		{
			return moreThanFiveLateDeliveries() ? 2 : 1;
		}
		private bool moreThanFiveLateDeliveries()
		{
			return numberOfLateDeliveries > 5;
		}
	}
}
