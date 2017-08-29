using NUnit.Framework;
using StringCalculator;

namespace StringCalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_WhenEmptyString_Returns0()
        {
            ArrangeActAssert("", 0);
        }

        [TestCase("1", 1)]
        [TestCase("2", 2)]
        public void Add_WhenSingleNumber_ReturnsThatNumber(string numbers, int expected)
        {            
            ArrangeActAssert(numbers, expected);
        }

        [TestCase("1,2", 3)]
        [TestCase("2,7", 9)]
        [TestCase("4,7", 11)]
        [TestCase("22,63", 85)]
        [TestCase("2,4,6,8,10",30)]
        public void Add_WhenMultipleNumbers_ReturnSumOfNumbers(string numbers, int expected)
        {
            ArrangeActAssert(numbers, expected);
        }

        [TestCase("1\n2\n3",6)]
        [TestCase("2\n8\n10", 20)]
        public void Add_WhenNumbersSplitWithNewLine_ReturnSumOfNumbers(string numbers, int expected)
        {
            ArrangeActAssert(numbers, expected);
        }

        [TestCase("//;\n1;2", 3)]
        [TestCase("//&\n1&2", 3)]
        public void Add_WhenNumbersContainsSpecifiedSeparator_ReturnSumOfNumbers(string numbers, int expected)
        {
            ArrangeActAssert(numbers,expected);
        }

        [TestCase("1,-2,3,4",8)]
        [TestCase("1,-2,3", 4)]
        public void Add_WhenContainsNegativeNumbers_ExcludeThemFromSum(string numbers, int expected)
        {
            ArrangeActAssert(numbers, expected);
        }

        private void ArrangeActAssert(string numbers, int expected)
        {
            var stringCalculator = new Calculator();
            var result = stringCalculator.Add(numbers);
            Assert.AreEqual(expected, result);
        }
    }
}
