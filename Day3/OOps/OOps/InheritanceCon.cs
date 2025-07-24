using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps
{
    class C1
    {
        public C1()
        {
            Console.WriteLine("Base class constructer ");
        }
    }
    class C2 : C1 
    {
        public C2()
        {
            Console.WriteLine("Derived class constructor ");
        }
        internal class InheritanceCon
        {
            static void Main()
            {
                C2 c = new C2();
            }
        }
    }
}
