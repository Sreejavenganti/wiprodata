using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class StrExample
    {
		static void Main()
		{
			string str = "Hello Dotnet....";
			try
			{
				Console.WriteLine(str.Substring(2, 150));
			}
			catch (ArgumentOutOfRangeException)
			{
                Console.WriteLine("string is small as range(2, 150)) is not possible");
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
			finally
			{

			}
		}
    }
}
