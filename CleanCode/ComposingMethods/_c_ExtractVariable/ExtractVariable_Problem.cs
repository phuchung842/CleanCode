using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.ComposingMethods._c_ExtractVariable
{
    //You have an expression that's hard to understand.
    class ExtractVariable_Problem
    {
        string platform = "MAC";
        string browser = "IE";
        int resize;
        private bool wasInitialized()
        {
            return false;
        }
        void renderBanner()
        {
            if ((platform.ToUpper().IndexOf("MAC") > -1)
                    && (browser.ToUpper().IndexOf("IE") > -1)
                    && wasInitialized() && resize > 0)
            {
                // do something
            }
        }
    }
}
