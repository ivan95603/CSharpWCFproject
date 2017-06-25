using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary
{
    public class WebClientServis : IWebClientServis
    {
        public string GetData(string value)
        {
            return "IVAN" + value;
        }
    }
}
