using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDemo
{
    public interface IEmploy
    {
        List<Employ> ShowEmploy();
        Employ SearchEmploy(int empno);
    }
}
