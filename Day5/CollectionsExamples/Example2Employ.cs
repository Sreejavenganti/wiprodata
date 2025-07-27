using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExamples
{
    internal class Example2Employ
    {
        static void Main()
        {
            Employ employ1 = new Employ();
            employ1.Empno = 1;
            employ1.Name = "Shiva";
            employ1.Basic = 88478;

            Employ employ2 = new Employ();  
            employ2.Empno = 2;
            employ2.Name = "Krishna";
            employ2.Basic = 89635;

            Employ employ3 = new Employ();
            employ3.Empno = 3;
            employ3.Name = "Radha";
            employ3.Basic = 98478;

            ArrayList employs = new ArrayList();
            employs.Add(employ1);
            employs.Add(employ2);
            employs.Add(employ3);

            foreach (Employ emp in employs)
            {
                Employ employ = (Employ)emp;
                Console.WriteLine(employ);
            }
        }

    }
}
