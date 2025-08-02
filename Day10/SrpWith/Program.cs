using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrpWith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employ employ = new Employ();
            employ.Empno = 1;
            employ.Name = "Krishna";
            employ.Basic = 85989.8;

            IEmployDao employDao = new EmployDaoImpl();
            employDao.AddEmploydao(employ);
            List<Employ> employList = employDao.GetAllEmploys();
            foreach (var v in employList)
            {
                Console.WriteLine(v);
            }
        }
    }
}
