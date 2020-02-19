using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CiscoCP3905Configurator
{
    public class Phone
    {
        public string phoneID { get; set; }
        public string phoneDesc { get; set; }

        public Phone()
        {

        }

        public void Clear()
        {
            phoneID = null;
            phoneDesc = null;
        }
    }
}
