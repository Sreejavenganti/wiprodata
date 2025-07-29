using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDemo
{
    [TestFixture]
    public class EmployDao : IEmploy
    {
        static List<Employ> employList;

        static EmployDao()
        {
            employList = new List<Employ>()
            {
                new Employ{Empno=1,Name="Lakshmi",Basic=88323},
                new Employ{Empno=2,Name="Lalitha",Basic=91911},
                new Employ{Empno=3,Name="Srinika",Basic=86444},
                new Employ{Empno=4,Name="Brivesh",Basic=89942},
                new Employ{Empno=5,Name="Ganadhitya",Basic=88932},
                new Employ{Empno=6,Name="Shlesha",Basic=81323},
            };
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

        public List<Employ> ShowEmploy()
        {
            return employList;
        }
    }
}
