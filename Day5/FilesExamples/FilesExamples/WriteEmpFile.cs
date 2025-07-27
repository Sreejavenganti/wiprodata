using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FilesExamples
{
    internal class WriteEmpFile
    {
        static void Main(string[] args)
        {
            Employ emp = new Employ();
            emp.Id = 2;
            emp.Name = "Rukmini";
            emp.Salary = 87380;
            FileStream fs = new FileStream(@"c:\files\Employee.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, emp);
            fs.Close();
            Console.WriteLine("Data is Stored....");
        }



    }
}
