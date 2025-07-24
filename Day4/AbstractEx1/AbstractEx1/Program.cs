using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Training[] arr = new Training[]
                {
                    new Krishna(),
                    new Vishnu(),
                    new Sreeja()
                };
            foreach (Training t in arr)
            {
                t.Company();
                t.Name();
                t.Email();
                Console.WriteLine("...........................");
            }
        }
    }
}
