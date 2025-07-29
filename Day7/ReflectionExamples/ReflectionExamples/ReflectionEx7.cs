using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    internal class ReflectionEx7
    {
        static void Main(string[] args)
        {
            Type objStudent = typeof(Student);
            Console.WriteLine("Methods Available are  ");
            foreach (MethodInfo method in objStudent.GetMethods())
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine("Fields Available are  ");
            foreach (FieldInfo field in objStudent.GetFields())
            {
                Console.WriteLine(field.Name);
            }
        }
    }
}
