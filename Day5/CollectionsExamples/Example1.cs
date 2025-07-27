using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExamples
{
    internal class Example1
    {
        static void Main(string[] args)
        {
            ArrayList namelist = new ArrayList();
            namelist.Add("Shiva");
            namelist.Add("Vishnu");
            namelist.Add("Durga");
            namelist.Add("Lakshmi");
            namelist.Add("Krishna");
            Console.WriteLine("Default arraylist elements are ");
            foreach (object obj in namelist)
            {
                Console.WriteLine(obj);
            }
            namelist.Insert(3, "Radha");
            Console.WriteLine("Arraylist after inserting new elements");
            foreach (object obj in namelist)
            {
                Console.WriteLine(obj);
            }
            namelist.Remove("Vishnu");
            Console.WriteLine("List after removing element");
            foreach (Object obj in namelist)
            {
                Console.WriteLine(obj);
            }
            namelist.RemoveAt(2);
            Console.WriteLine("List after Removing By Position  ");
            foreach (object obj in namelist)
            {
                Console.WriteLine(obj);
            }
        }


        
    }
}
