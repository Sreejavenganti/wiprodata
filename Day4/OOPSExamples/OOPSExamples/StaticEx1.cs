using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExamples
{
    internal class StaticEx1
    {
        static int count;
        public void Increment()
        {
            count++;
        }
        public void Show()
        {
            Console.WriteLine("count is " +count);
        }

        static void Main()
        {
            StaticEx1 ex1 = new StaticEx1();
            StaticEx1 ex2 = new StaticEx1();
            StaticEx1 ex3 = new StaticEx1();
           
            ex1.Increment();
            ex2.Increment();
            ex3.Increment();

            ex1.Show();

        }
    }
}
