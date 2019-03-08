using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Interfaces
{
    public interface IFizzBuzzStrategy
    {
        IEnumerable<IFizzBuzzProvider> Create(int i);
    }
}
