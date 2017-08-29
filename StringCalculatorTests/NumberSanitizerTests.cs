using NUnit.Framework;
using StringCalculator;

namespace StringCalculatorTests
{
    [TestFixture]
    public class NumberSanitizerTests
    {
        [TestCase("//;\n1;2", "1,2")]
        [TestCase("//&\n1&2", "1,2")]
        public void NumberSanitizer_WhenNumberContainsSeparatorSpecifier_ReturnStringWithDefaultSeparator(string numbers, string expected)
        {
            ArrangeActAndAssert(numbers, expected);
        }

        private void ArrangeActAndAssert(string numbers, string expected)
        {
            var numberSanitizer = new NumbersSanitizer(',');
            var result = numberSanitizer.SanitizeNumbers(numbers);
            Assert.AreEqual(result, expected);
        }
    }
}
