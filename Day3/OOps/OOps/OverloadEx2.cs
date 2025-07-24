using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps
{
    internal class OverloadEx2
    {
        public int Sum()
        {
            return 7;
        }
        public int Sum(int n)
        {
            return n + 7;
        }
        public int Sum(int n, int m)
        {
            return m + n;
        }
        static void Main()
        {
            OverloadEx2 obj = new OverloadEx2();
            Console.WriteLine("sum w.r.t zero args " + obj.Sum());
            Console.WriteLine("sum w.r.t one args " + obj.Sum(10));
            Console.WriteLine("sum w.r.t two args " + obj.Sum(27, 7));
        }
    }
}
