using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesExamples
{
    internal class BinaryReadExample
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"c:\files\Binary.txt", FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(fs);
            int x = reader.ReadInt32();
            string str = reader.ReadString();
            double b = reader.ReadDouble();
            bool flag = reader.ReadBoolean();
            Console.WriteLine(x);
            Console.WriteLine(str);
            Console.WriteLine(b);
            Console.WriteLine(flag);
            reader.Close();
            fs.Close();
        }
        
    }
}
