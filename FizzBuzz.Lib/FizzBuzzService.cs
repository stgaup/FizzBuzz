using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.Lib
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public IEnumerable<string> GetFizzBuzz(int max)
        {
            if(max < 1)
                throw new ArgumentOutOfRangeException(nameof(max));
            
            return Enumerable.Range(1, max)
                .Select(GetFizzBuzzForNumber)
                .ToList();
        }

        private string GetFizzBuzzForNumber(int number)
        {
            var fizz = number % 3 == 0 ? "Fizz" : string.Empty;
            var buzz = number % 5 == 0 ? "Buzz" : string.Empty;
            var fizzbuzz = $"{fizz}{buzz}";
            return string.IsNullOrWhiteSpace(fizzbuzz) ? number.ToString() : fizzbuzz;
        }
    }
}
