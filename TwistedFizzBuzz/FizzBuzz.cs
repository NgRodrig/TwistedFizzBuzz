using System.Text;

namespace TwistedFizzBuzz
{
    public class FizzBuzz
    {

        public static string Classic( int rangeStart, int rangeEnd) 
        {
            List<string> tokens = new() { "Fizz", "Buzz" };

            List<int> divisors = new() { 3,5 };

            return GeneralUsage(rangeStart,rangeEnd,divisors,tokens);
        }


        public static string RichRed(RichResponse RichRed)
        {
            List<string> tokens = new() { RichRed.Word };

            List<int> divisors = new() { RichRed.Multiple };

            return GeneralUsage(0, 100 , divisors, tokens);
        }

        public static string GeneralUsage(int rangeStart,int rangeEnd, List<int> divisors, List<string> tokens)
        {
            if (divisors.Count != tokens.Count)
            {
                throw new ArgumentException("There has to be the same number of divisors and tokens.");
            }

            List<int> range = new() { rangeStart,rangeEnd };

            StringBuilder output = new();

            if (range[0] > range[1]) { range.Reverse(); }

            for (int i = range[0]; i <= range[1]; i++)
            {
                output = InternalLoop(range, divisors, tokens, output, i);
            }

            return output.ToString();
        }

        public static string NonSequential(List<int> numbers, List<int> divisors, List<string> tokens)
        {
            if (divisors.Count!=tokens.Count)
            {
                throw new ArgumentException("There has to be the same number of divisors and tokens.");
            }

            StringBuilder output = new();

            for (int i = 0 ; i < numbers.Count; i++)
            {
                output = InternalLoop(numbers, divisors, tokens, output, numbers[i]);
            }

            return output.ToString();
        }

        private static StringBuilder InternalLoop(List<int> range, List<int> divisors, List<string> tokens, StringBuilder output, int i)
        {

            bool isNotMultiple = true;

            for (int j = 0; j < divisors.Count; j++)
            {
                
                if (ValidateMultipleOf(i, divisors[j]))
                {
                    output.Append(tokens[j]);
                    isNotMultiple = false;
                }
                
            }

            if (isNotMultiple){ output.Append(i); }

            output.AppendLine();

            return output;
        }

        private static Boolean ValidateMultipleOf(int number, int divisor) 
        {
            return number % divisor == 0;
        }

    }
}