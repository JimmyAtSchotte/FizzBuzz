using FizzBuzz.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzStrategy : IFizzBuzzStrategy
    {
        private readonly IFizzBuzzFactory[] _factories;

        public FizzBuzzStrategy(IFizzBuzzFactory[] factories)
        {
            _factories = factories;
        }

        public IEnumerable<IFizzBuzzProvider> Create(int i)
        {
            return _factories.Where(x => x.AppliesTo(i)).Select(x => x.Create());
        }
    }
}
