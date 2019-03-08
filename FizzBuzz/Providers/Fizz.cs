using FizzBuzz.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Providers
{
    public class FizzFactory : IFizzBuzzFactory
    {
        public bool AppliesTo(int i)
        {
            return i % 3 == 0;
        }

        public IFizzBuzzProvider Create()
        {
            return new FizzProvider();
        }
    }

    public class FizzProvider : IFizzBuzzProvider
    {
        public string GetOutput()
        {
            return "Fizz";
        }
    }
}
