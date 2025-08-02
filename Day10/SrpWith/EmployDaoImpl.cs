using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrpWith
{
    internal class EmployDaoImpl : IEmployDao
    {
        static List<Employ> employList;
        static EmployDaoImpl()
        {
            employList = new List<Employ>();
        }

        public string AddEmploydao(Employ employ)
        {
            employList.Add(employ);
            return " Employ Record is Inserted";
            
        }

        public List<Employ> GetAllEmploys()
        {
            return employList;
        }
    }
}
