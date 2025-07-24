using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps
{
    class First
    {
        public void Show()
        {
            Console.WriteLine("Display first ");
        }
    }
    class Second : First 
    {
        public void Display()
        {
            Console.WriteLine("Show Second" );
        }
    }
    internal class InheritanceEx
    {
        static void Main()
        {
            Second second = new Second();
            second.Show();
            second.Display();
        }
    }
}
