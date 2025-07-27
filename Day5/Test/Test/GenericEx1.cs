using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class GenericEx1
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T t;
            t = a;
            a = b;
            b = t;

        }
        static void Main(string[] args)
        {
            int a = 7, b = 8;
            Swap(ref a, ref b);
            Console.WriteLine("Value of A " +a+ " Value of B " +b);
            string s1 = "Shiva", s2 = "Parvathi";
            Swap(ref s1, ref s2);
            Console.WriteLine("S1 " + s1 + " S2 " + s2);
            double v = 27.8, s = 14.7;
            Swap(ref v, ref s);
            Console.WriteLine("V " + v + " S " + s );
            bool a1 = true, a2 = false;
            Swap(ref a1, ref a2);
            Console.WriteLine("A1 " +a1+ " A2 " +a2);
        }
    }
}
