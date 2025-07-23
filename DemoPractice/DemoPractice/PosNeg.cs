using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPractice
{
    internal class PosNeg
    {
        public void Check(int n)
        {
            if (n >= 0)
            {
                Console.WriteLine("Positive Number. ");
            }
            else
            {
                Console.WriteLine("Negative Number. ");
            }
        }
        static void Main()
        {
            int n;
            Console.WriteLine(" Enter  n value ");
            n = Convert.ToInt32(Console.ReadLine());
            PosNeg posNeg = new PosNeg();
            posNeg.Check(n);
        }
    }
}
