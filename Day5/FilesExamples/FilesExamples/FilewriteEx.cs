using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesExamples
{
    internal class FilewriteEx
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"c:\files\Data.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("This training is conducted by NGA");
            sw.WriteLine("On Great Learning Platform");
            sw.WriteLine("The trainer name is Prasanna Sir");
            sw.Flush();
            sw.Close();
            fs.Close();
            Console.WriteLine("File is created Successfully   ");
        }
    }
}
