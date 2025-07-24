using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExamples
{
    static class Demos
    {
        public static void Show()
        {
            Console.WriteLine("Show method from demos class ");
        }
        public static string Display()
        {
            return "Name is Durga";
        }


    }

    internal class StaticClass
    {
        static void Main()
        {
            Demos.Show();
            Console.WriteLine(Demos.Display());
        }
    }
}
