using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Division
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter 2 numbers ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Division value " + c);

            }
            catch(FormatException) 
            {
                Console.WriteLine("string cannot be converted into int ");
            
            }
            catch (OverflowException) 
            {
                Console.WriteLine("Big number");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Invalid ");
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Program from Wipro DotNet batch");
            }
        }
    }
}
