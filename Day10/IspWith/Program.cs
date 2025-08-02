using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspWith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rahul rahul = new Rahul();
            rahul.ShowPersonalInfo();
            Roshan roshan = new Roshan();
            roshan.ShowPersonalInfo();
            roshan.ProjectName();
            roshan.BillingInfo();
        }
    }
}
