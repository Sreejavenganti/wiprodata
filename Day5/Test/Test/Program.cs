using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Welcome to .Net  ");
            Console.WriteLine(sb);
            sb.AppendLine("Welcome to Training ");
            sb.AppendLine("Platform is Great Learning");
            Console.WriteLine(sb);
        }
    }
}
