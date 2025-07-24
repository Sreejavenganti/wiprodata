using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomArray
{
    public class Student
    {
        int id;
        string name;
        double cgpa;
        string city;

        public Student() { }

        public Student(int id, string name, double cgpa, string city)
        {
            this.id = id;
            this.name = name;
            this.cgpa = cgpa;
            this.city = city;
        }

        public override string ToString()
        {
            return "id " + id + " Name " + name + " Cgp  " + cgpa + " City " + city;
        }
    }
}
