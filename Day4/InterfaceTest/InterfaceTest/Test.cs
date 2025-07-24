using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    internal class Test : IntfOne, IntfTwo
    {
        

        void IntfOne.Show()
        {
            Console.WriteLine("First Interface");
        }

        void IntfTwo.Show()
        {
            Console.WriteLine("Second Interface");
        }
    }
}
