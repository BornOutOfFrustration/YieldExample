using System;
using System.Collections.Generic;

namespace YieldExample
{
    public class Example1
    {
        public void LoopOverYieldList()
        {
            foreach (var i in ListOfIntegersUsingYield())
            {
                Console.WriteLine(i);
            }
        }

        private IEnumerable<int> ListOfIntegersUsingYield()
        {
            yield return 1;
            yield return 2;
            yield return 4;
            yield return 8;
            yield return 16;
            yield return 16777216;
        }
    }
}
