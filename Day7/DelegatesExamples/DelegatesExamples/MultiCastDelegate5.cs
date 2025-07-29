using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class MultiCastDelegate5
    {
        public delegate void DotNet();

        public static void Milestone1()
        {
            Console.WriteLine("Milestone1 is on Core topics");
        }
        public static void Milestone2()
        {
            Console.WriteLine("Milestone2 is conducted on Dotnet Core");
        }
        public static void Milestone3()
        {
            Console.WriteLine("Milestone3 is conducted on Asp.net core WEB API ");
        }
        public static void Milestone4()
        {
            Console.WriteLine("Milestone4 is conducted on React Framework ");
        }
        public static void Project()
        {
            Console.WriteLine("Project to be done at Last");
        }
        static void Main(string[] args)
        {
            DotNet dot = new DotNet(Milestone1);
            dot += new DotNet(Milestone1);
            dot += new DotNet(Milestone3);
            dot += new DotNet(Milestone4);
            dot += new DotNet(Project);
            dot();
        }
    }
}
