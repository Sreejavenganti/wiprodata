using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    internal class ReflectionEx1
    {
        static void Main(string[] args)
        {
            Type typeobj = typeof(Test);
            Console.WriteLine("Methods available in Test class are ");
            foreach (MethodInfo mi in typeobj.GetMethods())
            {
                Console.WriteLine(mi.Name);
            }
            Console.WriteLine("Variables available in Test class Are ");
            foreach (FieldInfo fi in typeobj.GetFields())
            {
                Console.WriteLine(fi.Name);
            }
        }
    }
}
