namespace StringCalculator
{
    public class NumbersSanitizer
    {
        private readonly char _defaultSeparator;

        public NumbersSanitizer(char defaultSeparator)
        {
            _defaultSeparator = defaultSeparator;
        }
        public string SanitizeNumbers(string numbers)
        {
            if (ContainsSeparatorSpecifier(numbers))
            {
                numbers = ReplaceWithDefaultSeparator(numbers, numbers[2]);
                numbers = RemoveSeparatorSpecifier(numbers);
            }
            return ReplaceWithDefaultSeparator(numbers, '\n');

        }

        private static string RemoveSeparatorSpecifier(string numbers)
        {
            return numbers.Substring(4);
        }

        private string ReplaceWithDefaultSeparator(string numbers, char oldSeparator)
        {
            return numbers.Replace(oldSeparator, _defaultSeparator);
        }

        private static bool ContainsSeparatorSpecifier(string numbers)
        {
            return numbers.StartsWith("//");
        }
    }
}
