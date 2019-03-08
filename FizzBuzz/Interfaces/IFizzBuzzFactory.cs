using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Interfaces
{
    public interface IFizzBuzzFactory
    {
        bool AppliesTo(int i);

        IFizzBuzzProvider Create();
    }
}
