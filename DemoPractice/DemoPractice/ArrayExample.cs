using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPractice
{
    internal class ArrayExample
    {
        public void Show()
        {
            int[] a = new int[] { 8, 7, 1, 4, 2 };
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
            static void Main()
            {
                ArrayExample arrayExample = new ArrayExample();
                arrayExample.Show();
            }
        
    }
}
