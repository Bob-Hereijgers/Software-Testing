using EersteTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void SumTest()
        {
            var calculator = new Calculator();
            int a = 2;
            int b = 3;
            var expected = 5;
            var result = calculator.Sum(a, b);
            Assert.AreEqual(expected, result);
        }
    }
}
