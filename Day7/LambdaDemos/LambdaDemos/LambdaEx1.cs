using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemos
{
    internal class LambdaEx1
    {
        static void Main()
        {
            List<Employ> employList = new List<Employ>
            {
                new Employ { Empno = 1, Name = "Shiva", Basic = 90000 },
                new Employ { Empno = 2, Name = "Parvathi", Basic = 85000 },
                new Employ { Empno = 3, Name = "Vishnu", Basic = 80000 },
                new Employ { Empno = 4, Name = "SriLakshmi", Basic = 88000 },
                new Employ { Empno = 5, Name = "Sreeja", Basic = 60000 },
                new Employ { Empno = 6, Name = "Srinika", Basic = 50000 },
            };

            Console.WriteLine("Employ List ");
            var res1 = employList.Select(x => x);
            foreach (var employ in res1)
            {
                Console.WriteLine(employ);
            }
            var res2 = employList.Select(x => new { x.Name, x.Basic });
            Console.WriteLine("Projected Fields are");
            foreach (var employ in res2)
            {
                Console.WriteLine(employ);
            }

            var res3 = employList.Where(x => x.Basic >= 90000);
            Console.WriteLine("Basic greater than 90000 ");
            foreach (var employ in res3)
            {
                Console.WriteLine(employ);
            }
            var res4 = employList.Where(x => x.Name.StartsWith("S"));
            foreach (var employ in res4)
            {
                Console.WriteLine(employ);
            }
        }

            
           
    }
}
