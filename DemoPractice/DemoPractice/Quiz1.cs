using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPractice
{
    internal class Quiz1
    {
        int n;
        static void Main(string[] args)
        {
            int x = 14;
            Quiz1 obj1 = new Quiz1();
            obj1.n = x;
            Quiz1 obj2 = new Quiz1();
            obj2.n = 15;
            Console.WriteLine(obj1.n);
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

        }
    }
}
