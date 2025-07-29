using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace MockDemo
{
    [TestFixture]
    public class CalculationTest
    {
        [Test]
        public void TestSum()
        {
            Mock<Calculation> calc = new Mock<Calculation>();
            calc.Setup(x => x.Sum(7, 14)).Returns(21);
            Assert.AreEqual(21, calc.Object.Sum(7, 14));

        }
        [Test]

        public void TestSub()
        {

            Mock<Calculation> calc1 = new Mock<Calculation>();
            calc1.Setup(x => x.Sub(14, 7)).Returns(7);
            Assert.AreEqual(7, calc1.Object.Sub(14, 7));
        }
        [Test]
        public void Mult()
        {

            Mock<Calculation> calc2 = new Mock<Calculation>();
            calc2.Setup(x => x.Mult(14, 7)).Returns(98);
            Assert.AreEqual(98, calc2.Object.Mult(14, 7));
        }
    }
}



        
    
