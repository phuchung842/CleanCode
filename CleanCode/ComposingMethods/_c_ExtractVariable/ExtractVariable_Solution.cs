using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.ComposingMethods._c_ExtractVariable
{
    class ExtractVariable_Solution
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
            bool isMacOs = platform.ToUpper().IndexOf("MAC") > -1;
            bool isIE = browser.ToUpper().IndexOf("IE") > -1;
            bool wasResized = resize > 0;

            if (isMacOs && isIE && wasInitialized() && wasResized)
            {
                // do something
            }
        }
    }
}
