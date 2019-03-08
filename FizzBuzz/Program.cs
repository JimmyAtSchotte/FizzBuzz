using FizzBuzz.Interfaces;
using FizzBuzz.Providers;
using System;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzbuzzStrategy = new FizzBuzzStrategy(new IFizzBuzzFactory[] {
                new FizzFactory(),
                new BuzzFactory()
            });

            for (int i = 0; i < 100; i++)
            {
                var providers = fizzbuzzStrategy.Create(i);

                if (providers.Any())
                    Console.WriteLine(string.Join("", providers.Select(x => x.GetOutput())));
                else
                    Console.WriteLine(i.ToString());
            }

            Console.ReadLine();
        }
    }
}
