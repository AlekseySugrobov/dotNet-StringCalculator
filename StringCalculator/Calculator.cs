using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class Calculator
    {
        private const int DefaultValue = 0;
        private const char DefaultSeparator = ',';
        private readonly NumbersSanitizer _numbersSanitizer;
        private readonly NumbersExtractor _numbersExtractor;

        public Calculator()
        {
            _numbersSanitizer = new NumbersSanitizer(DefaultSeparator);
            _numbersExtractor = new NumbersExtractor(DefaultSeparator);
        }
        public int Add(string numbers)
        {
            numbers = _numbersSanitizer.SanitizeNumbers(numbers);
            if (ShouldReturnDefaultNumber(numbers))
                return DefaultValue;
            var extractedNumbers = _numbersExtractor.ExtractNumbers(numbers);
            return SumNumbers(extractedNumbers);
        }

        private int SumNumbers(IEnumerable<int> splitNumbers)
        {
            return splitNumbers.Sum();
        }


        private bool ShouldReturnDefaultNumber(string numbers)
        {
            return numbers == string.Empty;
        }
    }
}
