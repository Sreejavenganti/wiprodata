using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    internal class ReflectionEx3
    {
        static void Main(string[] args)
        {
            Assembly execution = Assembly.GetExecutingAssembly();
            Type[] types = execution.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine(type.Name);
                Console.WriteLine("Display methods of Assembly");
                MethodInfo[] methods = type.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine(method.Name);
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var par in parameters)
                    {
                        Console.WriteLine(par.Name + " " +par.ParameterType);
                    }
                }
            }
        }

    }
}
