using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExamples
{
    internal class Demo
    {
        static int count;
        public void Increment()
        {
            count++;
        }
        public void Show()
        {
            Console.WriteLine("Count is " + count);
        }
        static void Main()
        {
            Demo obj1 = new Demo();
            Demo obj2 = new Demo();
            obj1.Increment();
            obj1.Show();
            obj2.Increment();
            obj2.Show();

        }
    }
}
