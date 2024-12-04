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

            return parsedNumbers.Sum();
        }

    }

}

