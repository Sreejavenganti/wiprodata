using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            Console.WriteLine(calculation.Sum(10, 20));
            Console.WriteLine(calculation.Sub(20, 10));
            Console.WriteLine(calculation.Mult(10, 20));
        }
    }
}
