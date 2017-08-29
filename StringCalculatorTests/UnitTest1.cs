using NUnit.Framework;
using StringCalculator;

namespace StringCalculatorTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Add_WhenEmptyString_Returns0()
        {
            var stringCalculator = new Calculator();
            var result = stringCalculator.Add("");
            Assert.AreEqual(0, result);
        }
    }
}
