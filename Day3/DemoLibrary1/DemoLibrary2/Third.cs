using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary1;

namespace DemoLibrary2
{
    internal class Third : Demo
    {
        public void Test()
        {
            Third third = new Third();
            Console.WriteLine(third.publicStr);
            Console.WriteLine(third.ipStr);
            Console.WriteLine(third.protectedStr);
        }
    }
}
