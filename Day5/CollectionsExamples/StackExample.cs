using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExamples
{
    internal class StackExample
    {
        static void Main()
        {
            Stack stack = new Stack();
            stack.Push("Omkar");
            stack.Push("Abhyansh");
            stack.Push("Niskarsh");
            stack.Push("Isha");
            stack.Push("Kabir");
            Console.WriteLine("Data entered into a Stack  ");
            foreach (object o in stack)
            {
                Console.WriteLine(o);
            }
            stack.Pop();
            Console.WriteLine("Poping one element ");
            foreach (object o in stack)
            {
                Console.WriteLine(o);
            }
            stack.Pop();
            stack.Pop();
            Console.WriteLine("Poping Two elements ");
            foreach (object o in stack)
            {
                Console.WriteLine(o);
            }

        }

    }
}
    
