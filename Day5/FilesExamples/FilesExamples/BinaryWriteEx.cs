using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesExamples
{
    internal class BinaryWriteEx
    {
        static void Main()
        {
            FileStream fs = new FileStream(@"c:\files\Binary.txt", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(12);
            bw.Write("Sreenika");
            bw.Write(89650.8);
            bw.Write(true);
            bw.Close();
            fs.Close();
            Console.WriteLine("Primitive data is stored...");
        }

    }
}
