using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomArray;

namespace StudentDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray = new Student[]
            {
                new Student(1,"Eesha",9.2,"Hyderabad"),
                new Student(2,"Jyothi",8.9,"Vijayanagaram"),
                new Student(3, "Rohith",9.1,"Bangalore")
            };

            foreach (Student student in studentArray)
            {
                Console.WriteLine(student);
            }
        }
    }
}
