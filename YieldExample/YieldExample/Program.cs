namespace YieldExample
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var example1 = new Example1();
            example1.LoopOverYieldList();

            var example2 = new Example2();
            var x = example2.ListOfCharsUsingYield();
            List<Character> y = new List<Character>();
            y.AddRange(example2.ListOfCharsUsingYield()); // IEnum is Lazy loading. Do this to have the breakpoint triggered

            y.ForEach(a => Console.WriteLine(a.Char));
        }        
    }
}
