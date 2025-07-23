using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPractice
{
    internal class JaggedArrayEx1
    {
        static void Main()
        {
            int[][] jaggedArray = new int[2][];

            int[] a = new int[] { 1, 2, 3 };
            int[] b = new int[] { 4, 5, 6 };

            jaggedArray[0] = a;
            jaggedArray[1] = b;

            Console.WriteLine(jaggedArray[0][0]);
            Console.WriteLine(jaggedArray[0][1]);
            Console.WriteLine(jaggedArray[0][2]);

            Console.WriteLine(jaggedArray[1][0]);
            Console.WriteLine(jaggedArray[1][1]);
            Console.WriteLine(jaggedArray[1][2]);
        }


    }
}
