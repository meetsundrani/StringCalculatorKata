using System.Text.RegularExpressions;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            List<int> parsedNumbers = ParseStringToNum(numbers);

            CheckNegative(parsedNumbers);

            return parsedNumbers.Sum();
        }

        private static void CheckNegative(List<int> parsedNumbers)
        {
            // Check for negative numbers
            var negatives = parsedNumbers.Where(n => n < 0).ToList();
            if (negatives.Any())
            {
                throw new ArgumentException(
                    $"Negative numbers not allowed: {string.Join(", ", negatives)}");
            }
        }

        private static List<int> ParseStringToNum(string numbers)
        {
            var delimiter = ",";
            var numberString = numbers;

            var custDel = "";

            // Check for custom delimiter
            if (numbers.StartsWith("//"))
            {
                custDel = numbers[2].ToString();
                delimiter = delimiter + '|' + custDel;
                numberString = numbers.Substring(4);
            }

            // Replace newlines with delimiter
            numberString = numberString.Replace("\n", delimiter);

            var regex = Regex.Split(numberString, delimiter);

            var parsedNumbers = regex
                .Select(n => int.Parse(n.Trim()))
                .ToList();
            return parsedNumbers;
        }
    }
}