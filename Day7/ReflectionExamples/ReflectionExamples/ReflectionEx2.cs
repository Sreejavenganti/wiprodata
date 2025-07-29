using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    internal class ReflectionEx2
    {
        static void Main(string[] args)
        {
            Type t = typeof(string);
            Console.WriteLine("Name " + t.Name);
            Console.WriteLine("Full Name " + t.FullName);
            Console.WriteLine("Namespace " + t.Namespace);
            Console.WriteLine("Base Type " + t.BaseType);
        }
    }
}
