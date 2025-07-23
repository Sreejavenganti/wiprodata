using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPractice
{
    internal class RefEx
    {
        public void Calc(int n, ref int f)
        {
            for (int i = 1; i  <= n; i++)
            {
                f = f * i;
            }
        }
        static void Main(string[] args)
        {
            int n, f = 1;
            Console.WriteLine("Enter n value ");
            n = Convert.ToInt32(Console.ReadLine());
            RefEx calc = new RefEx();
            calc.Calc(n, ref f);
            Console.WriteLine("factorial of n " +f);

        }
    }
}
