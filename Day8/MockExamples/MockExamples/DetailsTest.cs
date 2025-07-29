using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace MockExamples
{
    [TestFixture]
    internal class DetailsTest
    {
        [Test]
        public void TestShowCompany()
        {
            Mock<IDetails> mock = new Mock<IDetails>();
            mock.Setup(x => x.ShowCompany()).Returns("It's from Wipro Hyderabad...");
            Assert.AreEqual("It's from Wipro Hyderabad...", mock.Object.ShowCompany());
        }

        [Test]
        public void TestShowStudent()
        {
            Mock<IDetails> obj = new Mock<IDetails>();
            obj.Setup(d => d.ShowStudent()).Returns("Hi I am Sreeja...");
            Assert.AreEqual("Hi I am Sreeja...", obj.Object.ShowStudent());
        }
    }
}
