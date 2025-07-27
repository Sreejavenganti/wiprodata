using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesExamples
{
    internal class FileReadEx1
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\wipro\Day5\PropertiesExamples\PropertiesExamples\AutoImplemented.cs", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            sr.Close();
            fs.Close();
        }
    }
}
