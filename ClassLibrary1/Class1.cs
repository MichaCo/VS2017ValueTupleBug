using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Class1
    {
        public (string a, string b) GetTuple()
        {
            return ("a", "b");
        }

        public IEnumerable<(string a, string b)> GetTuples()
        {
            yield return ("a", "b");
        }
    }
}