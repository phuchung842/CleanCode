using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.ComposingMethods._f_RemoveAssignmentstFromParameters
{
    class RemoveAssignmentstFromParameters_Solution
    {
		int discount(int inputVal, int quantity)
		{
			int result = inputVal;
			if (quantity > 50)
			{
				result -= 2;
			}
			return result;
		}
	}
}
