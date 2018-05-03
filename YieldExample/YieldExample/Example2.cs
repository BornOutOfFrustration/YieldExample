using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldExample
{
    public class Example2
    {
        List<string> stringList = new List<string>()
        {
            "A", "B", "C"
        };

        public IEnumerable<AcquisitionSettingsViewModel> LoadImageAcquisition()
        {
            foreach (var s in stringList)
            {
                yield return new AcquisitionSettingsViewModel() { s = s };
            }
        }
    }

    public class AcquisitionSettingsViewModel
    {
        public string s;
    }

}
