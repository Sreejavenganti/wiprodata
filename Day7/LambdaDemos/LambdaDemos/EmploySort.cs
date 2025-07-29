using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemos
{
    internal class EmploySort
    {
        static void Main()
        {
            List<Employ> employList = new List<Employ>
            {
                new Employ { Empno = 1, Name = "Shiva", Basic = 90000 },
                new Employ { Empno = 26, Name = "Parvathi", Basic = 85000 },
                new Employ { Empno = 5, Name = "Vishnu", Basic = 80000 },
                new Employ { Empno = 3, Name = "SriLakshmi", Basic = 88000 },
                new Employ { Empno = 27, Name = "Sreeja", Basic = 60000 },
                new Employ { Empno = 12, Name = "Srinika", Basic = 50000 },
            };

            employList.Sort();
            Console.WriteLine("Sorted Data w.r.t empno ");
            var res1 = employList.Select(x => x);
            foreach (var x in res1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Sort by Name-Wise");
            employList.Sort(new NameComparer());
            var res2 = employList.Select(x => x);
            foreach (var x in res2)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Sort by Basic-Wise");
            employList.Sort(new BasicComparer());
            var res3 = employList.Select(x => x);
            foreach (var x in res3)
            {
                Console.WriteLine(x);
            }
        }
     }
}
