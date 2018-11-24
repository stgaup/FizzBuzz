using FizzBuzz.Lib;
using System;

namespace FizzBuzz.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IFizzBuzzService fizzBuzzService = new FizzBuzzService();
 
            foreach (var result in fizzBuzzService.GetFizzBuzz(100))
            {
                System.Console.WriteLine(result);
            }
            System.Console.ReadLine();
        }
    }
}
