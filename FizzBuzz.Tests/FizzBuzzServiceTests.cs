using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using FizzBuzz.Lib;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzServiceTests
    {
        [Fact]
        public void CheckFizzBuzz()
        {
            var fizzbuzzService = new FizzBuzzService();
            var fizzBuzz = fizzbuzzService.GetFizzBuzz(100)?.ToArray();

            using (var file = File.OpenText(".\\FizzBuzz.txt"))
            {
                var i = 0;
                while (!file.EndOfStream)
                {
                    var expected = file.ReadLine();
                    var actual = fizzBuzz[i];
                    Assert.Equal(expected, actual);
                    i++;
                }
            }
        }

        [Fact]
        public void FizzBuzz_Max_Below_1_Throws_ArgumentOutOfRange()
        {
            var fizzbuzzService = new FizzBuzzService();
            Assert.Throws<ArgumentOutOfRangeException>(() => fizzbuzzService.GetFizzBuzz(0));
        }

        [Fact]
        public void FizzBuzz_Max_At_1_Returns_1()
        {
            var fizzbuzzService = new FizzBuzzService();
            Assert.Single(fizzbuzzService.GetFizzBuzz(1));
            Assert.Equal(1.ToString(), fizzbuzzService.GetFizzBuzz(1).FirstOrDefault());
        }
    }
}
