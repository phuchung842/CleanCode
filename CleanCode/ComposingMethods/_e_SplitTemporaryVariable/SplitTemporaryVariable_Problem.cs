using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.ComposingMethods._e_SplitTemporaryVariable
{
    //You have a local variable that's used to store various intermediate values 
    //inside a method (except for cycle variables).
    class SplitTemporaryVariable_Problem
    {
        private static int height;
        private static int width;
        void Run()
        {
            double temp = 2 * (height + width);
            Console.WriteLine(temp);
            temp = height * width;
            Console.WriteLine(temp);
        }
    }
}
