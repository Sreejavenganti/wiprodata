using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class ThrowEx
    {
        public void Show(int x)
        {
            if (x < 0)
            {

                throw new DivideByZeroException("Negative numbers are not allowed");
            }
            else if (x == 0)
            {
                throw new IndexOutOfRangeException("Zero is Invalid value ");
            }
            else
            {
                Console.WriteLine("N value: " + x);
            }
        }
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter x value ");
            x = Convert.ToInt32(Console.ReadLine());
            ThrowEx ex = new ThrowEx();
            try
            {
                ex.Show(x);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }

    }
}
