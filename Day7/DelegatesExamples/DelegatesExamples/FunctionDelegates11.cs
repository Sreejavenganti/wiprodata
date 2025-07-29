using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class FunctionDelegates11
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            return x - y;
        }
        public static int Mult(int x, int y)
        {
            return x * y;
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter 2 numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Func<int, int, int> obj = Sum;
            Console.WriteLine("Sum is " +obj(7, 8));
        }
    }
}
