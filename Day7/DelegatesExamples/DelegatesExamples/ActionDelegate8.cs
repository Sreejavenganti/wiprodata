using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class ActionDelegate8
    {
        public delegate void MyDelegate(string str);

        public static void Greeting(string str)
        {
            Console.WriteLine("Good Morning " +str );
        }
        static void Main(string[] args)
        {
            MyDelegate obj = Greeting;
            obj("Krishna");
        }

    }
}
