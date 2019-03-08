using FizzBuzz.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Providers
{
    public class BuzzFactory : IFizzBuzzFactory
    {
        public bool AppliesTo(int i)
        {
            return i % 5 == 0;
        }

        public IFizzBuzzProvider Create()
        {
            return new BuzzProvider();
        }
    }

    public class BuzzProvider : IFizzBuzzProvider
    {
        public string GetOutput()
        {
            return "Buzz";
        }
    }
}
