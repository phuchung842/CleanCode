using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.ComposingMethods._a_ExtractMethod
{
    //You have a code fragment that can be grouped together.
    public class ExtractMethod_Problem
    {
        string name = "Y";
        int amount = 4;
        private void printBanner()
        {

        }
        void printOwing()
        {
            printBanner();
            Console.WriteLine("name" + name);
            Console.WriteLine("amount" + amount);
        }
    }
}
