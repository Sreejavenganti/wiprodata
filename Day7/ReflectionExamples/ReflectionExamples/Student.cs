using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cgpa {  get; set; }

        public Student()
        {
            Id = 0;
            Name = string.Empty;
            Cgpa = 0.0;
        }
        public Student(int id, string name, double cgpa)
        {
            Id = id;
            Name = name;
            Cgpa = cgpa;
        }

        public override string ToString()
        {
            return "Student Id " +Id+ " Student Name " +Name+ " Cgpa " +Cgpa;
        }
        public void AddStudent(Student student)
        {
            Console.WriteLine("Please Add Student ");
        }
        public void ShowStudent()
        {
            Console.WriteLine("Under Construction ");
        }
        public void SearchStudent(int id)
        {
            Console.WriteLine("Search student " + id);
        }
        public void DeleteStudent(int id)
        {
            Console.WriteLine("Remove student " + id);
        }
    }
}
