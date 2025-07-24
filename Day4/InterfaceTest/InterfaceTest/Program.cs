using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntfOne obj1 = new Test();
            obj1.Show();

            IntfTwo obj2 = new Test();
            obj2.Show();
        }
    }
}
