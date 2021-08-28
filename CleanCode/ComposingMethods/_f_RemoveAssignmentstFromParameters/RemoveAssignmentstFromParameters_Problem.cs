using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.ComposingMethods._f_RemoveAssignmentstFromParameters
{
	//Some value is assigned to a parameter inside method's body
	class RemoveAssignmentstFromParameters_Problem
    {
		int discount(int inputVal, int quantity)
		{
			if (quantity > 50)
			{
				inputVal -= 2;
			}
			return quantity;
		}
	}
}
