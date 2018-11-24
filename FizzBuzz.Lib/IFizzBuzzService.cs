using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Lib
{
    public interface IFizzBuzzService
    {
        IEnumerable<string> GetFizzBuzz(int max);
    }
}
