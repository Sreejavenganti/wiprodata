using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesExamples
{
    [Serializable]
    internal class Employ
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return "Employ id " +Id+ " Name " +Name+ " Salary " +Salary;
        }

    }
}
