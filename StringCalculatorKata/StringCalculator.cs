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

            var delimiter = ",";
            var numberString = numbers;

            // Check for custom delimiter
            if (numbers.StartsWith("//"))
            {
                delimiter = numbers[2].ToString();
                numberString = numbers.Substring(4);
            }


            // Replace newlines with delimiter
            numberString = numberString.Replace("\n", delimiter);

            var parsedNumbers = numberString
                .Split(delimiter)
                .Select(n => int.Parse(n.Trim()))
                .ToList();

            // Check for negative numbers
            var negatives = parsedNumbers.Where(n => n < 0).ToList();
            if (negatives.Any())
            {
                throw new ArgumentException(
                    $"Negative numbers not allowed: {string.Join(", ", negatives)}");
            }

            return parsedNumbers.Sum();
        }
    }
}