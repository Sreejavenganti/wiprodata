using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPractice
{
    internal class JaggedArrayEx3
    {
        static void Main()
        {
            int n, m;
            Console.WriteLine("Enter no. of jaggedarrays and size of array ");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());

            int[][] jaggedArray = new int[n][];

            int[] x = new int[m];
            int[] y = new int[m];


            Console.WriteLine("Enter elements of Array x ");
            for (int i = 0; i < m; i++)
            {
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter elements of Array y ");
            for (int i = 0; i < m; i++)
            {
                y[i] = Convert.ToByte(Console.ReadLine());

            }

            jaggedArray[0] = x;
            jaggedArray[1] = y;

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "  ");
                }
                Console.WriteLine();
            }

        }
    }

        
}
