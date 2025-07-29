using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployProject.Models;
using EmployProject.Exceptions;
using EmployProject.Dao;
using System.CodeDom;


namespace EmployProject.Bal
{
    public class EmployBal
    {
       public StringBuilder sb = new StringBuilder();
        public static EmployDaoImpl daoImpl;

        static EmployBal()
        {
            daoImpl = new EmployDaoImpl();
        }
        public List<Employ> ShowEmployBal()
        {
            return daoImpl.ShowEmployDao();
        }
        public string WriteFileBal()
        {
            return daoImpl.WritetoFileDao();
        }
        public string ReadFileBal()
        {
            return daoImpl.ReadfromFileDao();
        }
        public string DeleteEmployBal(int empno)
        {
            return daoImpl.DeleteEmployDao(empno);
        }
        public string UpdateEmployBal(Employ employUpdated)
        {
            if (ValidateEmploy(employUpdated) == true)
            {
                return daoImpl.UpdateEmployDao(employUpdated);
            }
            throw new EmployException (sb.ToString());
        }
        public Employ SearchEmployBal(int empno)
        {
            return daoImpl.SearchEmployDao(empno);
        }
        public string AddEmployBal(Employ employ) 
        {
            if (ValidateEmploy(employ) == true)
            {
                return daoImpl.AddEmployDao(employ);
            }
            throw new EmployException(sb.ToString());

        }
        public bool ValidateEmploy(Employ employ)
        {
            bool flag = true;
            if (employ.Empno <= 0)
            {
                sb.Append("Employ number cannot be zero or Negative......\n");
                flag = false;
            }
            if (employ.Name.Length < 5)
            {
                sb.Append("Name contains Minimum of 5 chars");
                flag = false;
            }
            if (employ.Salary < 10000 || employ.Salary > 80000)
            {
                sb.Append("Salary should be between 10000 and 80000");
                flag |= false;
            }
            return flag;
        }

    }
}
