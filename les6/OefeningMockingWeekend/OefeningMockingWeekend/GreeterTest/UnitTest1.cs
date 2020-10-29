using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace OefeningMockingWeekend.Test
{
    [TestClass]
    public class WeekendTest
    {
        [TestMethod()]
        public void GetMessage_Returns_Workhard_When_It_Is_Not_Weekend()
        {
            var dateGetter = new Mock<IDateGetter>();
            dateGetter.Setup(x => x.GetDate()).Returns(new DateTime(2020, 10, 23));


            var greeter = new Greeter(dateGetter.Object);
            Assert.AreEqual("Work hard, weekend is on his way....", greeter.GetMessage());
        }

        [TestMethod()]
        public void GetMessage_Returns_PartyTime_When_It_Is_Weekend()
        {
            var dateGetter = new Mock<IDateGetter>();
            dateGetter.Setup(x => x.GetDate()).Returns(new DateTime(2020, 10, 24));


            var greeter = new Greeter(dateGetter.Object);
            Assert.AreEqual("Party time.....it's weekend", greeter.GetMessage());
        }
    }
}