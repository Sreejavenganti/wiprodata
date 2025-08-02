using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspWith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Details[] arr = new Details[]
            {
                new SriRam(),
                new Bhumija(),
                new Radha()
            };
            foreach (var item in arr)
            {
                item.ShowInfo();
            }
        }
    }
}
