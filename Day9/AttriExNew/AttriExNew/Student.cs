using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttriExNew
{
    [Information(InformationString = "Class")]
    public class Student
    {
        private int sid;
        private string name;

        [Information(InformationString = "Constructer")]
        public Student (int sid, string name)
        {
            this.sid = sid;
            this.name = name;
        }

        [Information(InformationString = "Method")]
        public void Display()
        {
            Console.WriteLine("Sid " +sid+ "Name" +name);
        }
    }

    
}
