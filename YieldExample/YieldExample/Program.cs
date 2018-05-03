using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Consumer();

            var example2 = new Example2();
            var x = example2.LoadImageAcquisition();
            List<AcquisitionSettingsViewModel> y = new List<AcquisitionSettingsViewModel>();
            y.AddRange(example2.LoadImageAcquisition()); // Lazy loading.

            y.ForEach(a => Console.WriteLine(a.s));

        }

        public static void Consumer()
        {
            foreach(var i in Integers())
            {
                Console.WriteLine(i);
            }

        }

        public static IEnumerable<int> Integers()
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
