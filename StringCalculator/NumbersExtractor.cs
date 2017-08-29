using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class NumbersExtractor
    {
        private readonly char _defaultSeparator;

        public NumbersExtractor(char defaultSeparator)
        {
            _defaultSeparator = defaultSeparator;
        }
        public List<int> ExtractNumbers(string numbers)
        {
            var splitNumbers = ConvertToNumbersList(numbers);
            splitNumbers = RemoveNegativeNumbers(splitNumbers);
            return splitNumbers;
        }

        private List<int> RemoveNegativeNumbers(IEnumerable<int> splitNumbers)
        {
            return splitNumbers.Where(number => number >= 0).ToList();
        }

        private List<int> ConvertToNumbersList(string numbers)
        {
            var splitNumbers = SplitNumbers(numbers);
            return splitNumbers.Select(ConvertSingleNumber).ToList();
        }

        private IEnumerable<string> SplitNumbers(string numbers)
        {
            return numbers.Split(_defaultSeparator);
        }

        private int ConvertSingleNumber(string numbers)
        {
            return int.Parse(numbers);
        }
    }
}
