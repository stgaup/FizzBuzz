using FizzBuzz.Lib;
using Microsoft.Extensions.DependencyInjection;
using System;
using Serilog;

namespace FizzBuzz.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup DI
            var serviceProvider = GetServiceProvider();

            //configure logging
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("FizzBuzz.log")
                .CreateLogger();

            Log.Information("Getting FizzBuzz service");
            IFizzBuzzService fizzBuzzService;
            try
            {
                fizzBuzzService = serviceProvider.GetService<IFizzBuzzService>();
            }
            catch (Exception e)
            {
                Log.Error(e, "FizzBuzz failed: {ErrorMessage}", e.Message);
                throw;
            }
            
 
            foreach (var result in fizzBuzzService.GetFizzBuzz(100))
            {
                System.Console.WriteLine(result);
            }
            System.Console.ReadLine();
        }

        public static ServiceProvider GetServiceProvider()
            =>  new ServiceCollection()
                .AddSingleton<IFizzBuzzService, FizzBuzzService>()
                .BuildServiceProvider();
    }
}
