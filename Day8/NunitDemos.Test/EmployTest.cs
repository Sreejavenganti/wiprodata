using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitDemos.Test
{
    [TestFixture]
    internal class EmployTest
    {
        [Test]
        public void TestSearchEmploy()
        {
            EmployDao employDao = new EmployDao();
            Employ employFound = employDao.SearchEmploy(1);
            Assert.IsNotNull(employFound);
            employFound = employDao.SearchEmploy(-1);
            Assert.Null(employFound);
        }

        [Test]
        public void TestShowEmploy()
        {
            List<Employ> employs = new EmployDao().ShowEmploy();
        Assert.AreEqual(5, employs.Count());
        }

        [Test]
        public void TestToString()
        {
            Employ employ = new Employ();
            employ.Empno = 1;
            employ.Name = "Vishnu";
            employ.Basic = 77000;

            string expected = "Employ No 1 Employ Name Vishnu Basic 77000";
            Assert.AreEqual(expected, employ.ToString());
        }

        [Test]

        public void TestGetterSetter()
        {
            Employ e = new Employ();
            e.Empno = 8;
            e.Name = "Vanaja";
            e.Basic = 880450.27;

            Assert.AreEqual(8, e.Empno);
            Assert.AreEqual("Vanaja", e.Name);
            Assert.AreEqual(880450.27, e.Basic);

         }
        [Test]

        public void TestConstructor()
        {
            Employ e = new Employ();
            Assert.NotNull(e);
            Employ employ = new Employ(27, "Sreeja", 85000);
            Assert.AreEqual(27, employ.Empno);
            Assert.AreEqual("Sreeja", employ.Name);
            Assert.AreEqual(85000, employ.Basic);
        }

    }
}
