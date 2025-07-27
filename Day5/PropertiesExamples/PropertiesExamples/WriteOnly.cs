using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExamples
{
    internal class WriteOnly
    {
        class Vendor
        {
            int vendorId;
            string vendorName;
            public int VendorId
            {
                set { vendorId = value; }
            }
            public string VendorName
            {
                set { vendorName = value; }
            }
            public override string ToString()
            {
                return "Vendor id " + vendorId + " Vendor Name " + vendorName;
            }

        }
        static void Main(string[] args)
        {
            Vendor v = new Vendor();
            v.VendorId = 1;
            v.VendorName = "Madhav";
            Console.WriteLine(v);
        
        }
    }
}
