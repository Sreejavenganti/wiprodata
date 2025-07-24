using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class ArrayEx
    {
        static void Main(string[] args)
        {
	
                int[] a = new int[] { 1, 2 };

				try
				{
					a[10] = 450;
				}
				catch (IndexOutOfRangeException)
				{
                    Console.WriteLine("Small Array...");
				}
				catch (Exception e)
				{

                    Console.WriteLine(e);
				}
	
        }
    }
}
