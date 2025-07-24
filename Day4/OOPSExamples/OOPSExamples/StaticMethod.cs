using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExamples
{
    class Data
    {
        public void Show()
        {
            Console.WriteLine("Show method for class Data");
        }
        public static void Display()
        {
            Console.WriteLine("Display method for class Data");
        }
    }
    internal class StaticMethod
    {
        static void Main()
        {
            Data.Display();
            new Data().Show();
        }

    }
}
