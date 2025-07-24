using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary2
{
    public class Second
    {
        public void Show()
        {
            DemoLibrary1.Demo obj = new DemoLibrary1.Demo();
            Console.WriteLine(obj.publicStr);
        }
    }
}
