using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitDemos
{
    public class EmployDao
    {
        static List<Employ> employList;

        public EmployDao()
        {
            employList = new List<Employ>()
            {
                new Employ { Empno = 1, Name = "Vasuki", Basic = 89000 },
                new Employ { Empno = 2, Name = "Krishna", Basic = 80000 },
                new Employ { Empno = 3, Name = "Ekaksh", Basic = 79000 },
                new Employ { Empno = 4, Name = "Shiva", Basic = 75000 },
                new Employ { Empno = 5, Name = "Bhairav", Basic = 70000 }
            };
        }

        public List<Employ> ShowEmploy()
        {
            return employList;
        }

        public Employ SearchEmploy(int empno)
        {
            Employ employFound = null;
            foreach (Employ employ in employList)
            {
                if (employ.Empno == empno)
                {
                    employFound = employ;
                }
            }
            return employFound;
        }

    }
}
