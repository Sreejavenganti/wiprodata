using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPractice
{
    internal class Matrix
    {
        static void Main()
        {
            int[,] k = new int[2, 3]
            {
               { 1, 2, 3 },
               { 4, 5, 6 }
            };

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
