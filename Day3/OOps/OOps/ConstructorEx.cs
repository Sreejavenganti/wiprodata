using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps
{
    internal class ConstructorEx
    {
        static ConstructorEx()
        {
            Console.WriteLine("Display Static Constructor");
        }
        ConstructorEx()
        {
            Console.WriteLine("Display Instance Constructor");
        }
        static void Main()
        {
            ConstructorEx c = new ConstructorEx();
        }
    }
}
