using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployProject.Models
{
    [Serializable]
    public class Employ
    {
        public int Empno  { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Depart { get; set; }
        public string Desig { get; set; }
        public double Salary { get; set; }

        public Employ() { }

        public Employ(int empno, string name, string gender, string depart, string desig, double salary)
        {
            Empno = empno;
            Name = name;
            Gender = gender;
            Depart = depart;
            Desig = desig;
            Salary = salary;
        }

        public override string ToString()
        {
            return "Employ no " + Empno +
                  " Name " + Name +
                  " Gender " + Gender +
                  " Department " + Depart +
                  " Designation " + Desig +
                  " Salary " + Salary;
        }
    }
}
