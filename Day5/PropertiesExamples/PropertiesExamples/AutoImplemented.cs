using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExamples
{
    class Employ
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Basic { get; set; }
    }
    internal class AutoImplemented
    {
        static void Main(string[] args)
        {
            Employ employ1 = new Employ();
            employ1.Id = 1;
            employ1.Name = "Devaki";
            employ1.Basic = 87837.45;

            Employ employ2 = new Employ();
            employ2.Id = 2;
            employ2.Name = "Krishna";
            employ2.Basic = 98937;

            Employ employ3 = new Employ();
            employ3.Id = 3;
            employ3.Name = "Radha";
            employ3.Basic = 87483;

            Console.WriteLine("First employ record  ");
            Console.WriteLine("Employ id " +employ1.Id + " Name " +employ1.Name + " Basic " +employ1.Basic);
            Console.WriteLine("Employ id " + employ2.Id + " Name " + employ2.Name + " Basic " + employ2.Basic);
            Console.WriteLine("Employ id " + employ3.Id + " Name " + employ3.Name + " Basic " + employ3.Basic);
        }
        
    }
}
