using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.ComposingMethods._e_SplitTemporaryVariable
{
    class SplitTemporaryVariable_Solution
    {
        private static int height;
        private static int width;
        void Run()
        {
            double perimeter = 2 * (height + width);
            Console.WriteLine(perimeter);
            double area = height * width;
            Console.WriteLine(area);
        }
    }
}
