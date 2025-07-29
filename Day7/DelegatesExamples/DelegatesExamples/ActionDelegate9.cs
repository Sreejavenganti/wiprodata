using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class ActionDelegate9
    {
        public static void Greeting(string str)
        {
            Console.WriteLine("Good Morning " +str);
        }
        public static void Endnote(string str)
        {
            Console.WriteLine("Good Night " + str);
        }
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter Name ");
            str = Console.ReadLine();
            Action<String> action = Greeting;
            action += Endnote;
            action(str);
        }
    }
}
