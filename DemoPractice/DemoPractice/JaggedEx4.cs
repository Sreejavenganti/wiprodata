using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPractice
{
    internal class JaggedEx4
    {
        static void Main()
        {
            int n, m;
            Console.WriteLine("enter rows and columns ");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());

            int[][] jaggedArray = new int[n][];

            int[,] a = new int[n, m];
            Console.WriteLine("Enter the elements for multidimensional array ");

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Display in matrix format ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Adding Data to Jagged Array");
            for (int i = 0; i < n; i++)
            {
                int[] p = new int[m];
                for (int j = 0; j < m; j++)
                {
                    //Console.WriteLine(a[i,j]);
                    p[j] = a[i, j];
                    
                }
                jaggedArray[i] = p;
            }

            Console.WriteLine("jagged done");
            Console.WriteLine("Print jagged array data ");
            Console.WriteLine(jaggedArray.Length);
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "    ");
                }
                Console.WriteLine();
            }
        }
    }
}
