using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class NullableEmployEx1
    {
        static void Main(string[] args)
        {
            Employ employ1 = new Employ();
            employ1.Empno = 1;
            employ1.Name = "Durga";
            employ1.Basic = 68998;

            Employ employ2 = new Employ();
            employ2.Empno = 2;
            employ2.Name = "Sreeja";
            employ2.Basic = 89878;
            employ2.LeaveDays = 3;

            if (employ1.LeaveDays.HasValue)
            {
                Console.WriteLine("{0} taken leave ", employ1.Name);
                employ1.Status = 0;
            }
            else
            {
                Console.WriteLine("{0} not taken leave ", employ1.Name);
                employ1.Status = 0;
            }
            if (employ2.LeaveDays.HasValue)
            {
                Console.WriteLine("{0} taken leave ", employ2.Name);
                employ2.Status = 0;
            }
            else
            {
                Console.WriteLine("{0} not taken leave ", employ2.Name);
                employ2.Status = 1;
            }
        }
    }
}
