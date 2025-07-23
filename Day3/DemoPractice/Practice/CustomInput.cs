using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPractice
{
    internal class CustomInput
    {
        static void Main()
        {
            int n, m;
            Console.WriteLine("Enter rows and columns ");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            int[,] k = new int[n, m];


            Console.WriteLine("Enter Array elements (total {0})  ",n*m);
            for (int i = 0; i < k.GetLength(0); i++)
            {
                for (int j = 0; j < k.GetLength(n-1); j++)
                {
                    k[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Display Array elements in Matrix");
            for (int i = 0; i < k.GetLength(0); i++)
            {
                for (int j = 0; j < k.GetLength(1); j++)
                {
                    Console.Write(k[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
