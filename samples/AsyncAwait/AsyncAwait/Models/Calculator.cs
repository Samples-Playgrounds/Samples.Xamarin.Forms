using System;
using System.Threading.Tasks;

namespace AsyncAwait.Models
{
    public class Calculator
    {
        public double Calculate (long number)
        {
            double result = 1.0;

            for (long i = 2; i <= number; i += 1)
            {
                result += i;
            }

            return result;
        }

        public double CalculateRecursive(long number)
        {
            return number > 1 ? number * CalculateRecursive(number - 1) : 1;
        }

        public Task<double> CalculateAsync(long number)
        {
            double result = 1.0;

            for (long i = 2; i <= number; i += 1)
            {
                result += i;
            }

            return Task.FromResult<double>(result);
        }

    }
}