using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using EmployProject.Models;

namespace EmployProject.Dao
{
    public class EmployDaoImpl : IEmployDao
    {
        static List<Employ> employList;

        static EmployDaoImpl()
        {
            employList = new List<Employ>();
        }
        public string AddEmployDao(Employ employ)
        {
            employList.Add(employ);
            return "Employ Record Inserted...";
        }
        public string DeleteEmployDao(int empno)
        {
            Employ employFound = SearchEmployDao(empno);
            if(employFound != null)
            {
                employList.Remove(employFound);
                return "Employ Record Deleted Successfully";
            }
            return "Employ record not Found";
        }

        public string ReadfromFileDao()
        {
            FileStream fs = new FileStream(@"c:\files\Employ.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            employList = (List<Employ>)formatter.Deserialize(fs);
            return "Data retrieved from File Successfully...";
        }

        public Employ SearchEmployDao(int empno)
        {
            Employ employFound = null;
            foreach (Employ employ in employList)
            {
                if (employ.Empno == empno)
                {
                    employFound = employ;
                    break;
                }
            }
            return employFound;
        }

        public List<Employ> ShowEmployDao()
        {
            return employList;
        }
        public string UpdateEmployDao(Employ employUpdated)
        {
            Employ employFound = SearchEmployDao(employUpdated.Empno);
            if (employFound != null)
            {
                employFound.Empno = employUpdated.Empno;
                employFound.Name = employUpdated.Name;
                employFound.Depart = employUpdated.Depart;
                employFound.Desig = employUpdated.Desig;
                employFound.Salary = employUpdated.Salary;
                return "Employ Record Updated ";
            }
            return "Employ Records are not Found";
        }
        public string WritetoFileDao()
        {
            FileStream fs = new FileStream(@"c:\files\Employ.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, employList);
            return "Data stored in File Successfully...";
        }


    }
}
