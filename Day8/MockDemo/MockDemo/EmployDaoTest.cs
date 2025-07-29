using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace MockDemo
{

    public class EmployDaoTest
    {
        List<Employ> employList = new List<Employ>()
        {
            new Employ{Empno=1,Name="Lakshmi",Basic=88323},
            new Employ{Empno=2,Name="Lalitha",Basic=91911},
            new Employ{Empno=3,Name="Srinika",Basic=86444},
        };
        Employ e1 = new Employ { Empno = 1, Name = "Isha", Basic = 79898 };
        Employ e2 = new Employ { Empno = 2, Name = "Durga", Basic = 87897 };

        Employ e3 = null;
        [Test]
        public void TestShowEmployList()
        {
            Mock<IEmploy> mock = new Mock<IEmploy>();
            mock.Setup(x => x.ShowEmploy()).Returns(employList);
            Assert.AreEqual(3, mock.Object.ShowEmploy().Count);

        }

        [Test]

        public void TestSearchEmploy()
        {
            Mock<IEmploy> mock = new Mock<IEmploy>();
            mock.Setup(x => x.SearchEmploy(1)).Returns(e1);
            Assert.IsNotNull(mock.Object.SearchEmploy(1));
            mock.Setup(x => x.SearchEmploy(100)).Returns(e2);
            Assert.IsNotNull(mock.Object.SearchEmploy(100));
            mock.Setup(x => x.SearchEmploy(200)).Returns(e3);
            Assert.IsNull(mock.Object.SearchEmploy(200));
        }
    }
}



