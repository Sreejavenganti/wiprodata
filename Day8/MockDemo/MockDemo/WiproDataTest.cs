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
    public class WiproDataTest
    {
        [Test]
        public void TestMileStone1()
        {
            Mock<IWiproData> mock = new Mock<IWiproData>();
            mock.Setup(x => x.MilestoneExam1()).Returns("Milestone Exam 1 is on Aug 1 ");
            Assert.AreEqual("Milestone Exam 1 is on Aug 1 ", mock.Object.MilestoneExam1());
        }

        [Test]
        public void TestMileStone2()
        {
            Mock<IWiproData> obj = new Mock<IWiproData>();
            obj.Setup(x => x.MilestoneExam2()).Returns("Milestone Exam 2 is on Aug 9 ");
            Assert.AreEqual("Milestone Exam 2 is on Aug 9 ", obj.Object.MilestoneExam2());
        }


    }
}
