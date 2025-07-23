using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPractice
{
    internal class ArrayCopy
    {
        public void Show()
        {
            int[] a = new int[] { 8, 7, 1, 4, 27 };
            int[] b = a;
            for (int i = 0; i < b.Length; i++) {
                Console.WriteLine(b[i]);
            }
        }
        static void Main(string[] args)
        {
            ArrayCopy arrayCopy = new ArrayCopy();
            arrayCopy.Show();
        }
    }
}
