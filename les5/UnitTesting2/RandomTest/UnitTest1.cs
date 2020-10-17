using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting2;

namespace RandomTest
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void RateGuess_Returns_2_When_Is_Correct()
        {
            var numberGame = new NumberGame();
            var result = numberGame.RateGuess(5);
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void RateGuess_Returns_2_When_Is_Wrong()
        {
            var numberGame = new NumberGame();
            var result = numberGame.RateGuess(3);
            Assert.AreEqual(0, result);
        }
    }
}
