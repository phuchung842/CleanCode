using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.ComposingMethods._a_ExtractMethod
{
    class ExtractMethod_Solution
    {
		string name = "Y";
		int amount = 4;
		void printOwing()
		{
			printBanner();
			printDetails();
		}
		private void printBanner()
		{
		}
		private void printDetails()
		{
			Console.WriteLine("name: " + name);
			Console.WriteLine("amount: " + amount);
		}
	}
}
