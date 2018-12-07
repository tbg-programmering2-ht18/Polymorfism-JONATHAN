using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism2
{
    class A
    {
        public string Description()
        {
            return "objektet är av typen A";
        }
    }
    class B: A
    {
        public new string Description()
        {
            return "objektet är av typen B";
        }
    }
}
