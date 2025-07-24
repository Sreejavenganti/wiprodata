using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExs
{
    internal class Second : First
    {
        public void Show()
        {
            base.Show();
            Console.WriteLine("Show method from class Second...");
        }
    }
}
