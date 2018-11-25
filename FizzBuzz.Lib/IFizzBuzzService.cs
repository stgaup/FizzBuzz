using System.Collections.Generic;

namespace FizzBuzz.Lib
{
    public interface IFizzBuzzService
    {
        IEnumerable<string> GetFizzBuzz(int max);
    }
}
