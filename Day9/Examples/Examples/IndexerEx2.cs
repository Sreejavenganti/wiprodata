using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class IndexerEx2
    {
        EmployN[] arr = new EmployN[5];
        public EmployN this[int id]
        {
            get
            {
                return arr[id];
            }
            set
            {
                arr[id] = value;
            }
        }
        static void Main()
        {
            IndexerEx2 indexerEx2 = new IndexerEx2();
            indexerEx2[0] = new EmployN { Empno = 1, Name = "Krishna", Basic = 87989 };
            indexerEx2[1] = new EmployN { Empno = 2, Name = "Pashupathi", Basic = 78784 };
            indexerEx2[2] = new EmployN { Empno = 3, Name = "Sri Ram ", Basic = 89389 };
            indexerEx2[3] = new EmployN { Empno = 4, Name = "Ganesh", Basic = 98348 };

            foreach (var n in indexerEx2.arr)
            {
                Console.WriteLine(n);
            }
        }
    }
}
