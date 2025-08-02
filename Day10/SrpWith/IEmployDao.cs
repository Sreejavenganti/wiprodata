using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrpWith
{
    internal interface IEmployDao
    {
        string AddEmploydao(Employ employ);
        List<Employ> GetAllEmploys();

    }
}
