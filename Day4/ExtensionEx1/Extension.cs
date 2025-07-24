using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionEx1
{
    internal static class Extension
    {
        public static int Mult(this Calculation Calc, int x, int y)
        {
            return x * y;
        }
    }
}
