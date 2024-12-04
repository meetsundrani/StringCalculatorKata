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
            var parsedNumbers = numbers
                .Split(delimiter)
                .Select(n => int.Parse(n.Trim()))
                .ToList();
            return parsedNumbers.Sum();
        }

    }

}

