using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProj
{
    class DataDictionary
    {
        public Dictionary<string, int> cDictionary { get; private set; }

        public void SampleDictionary()
        {
            cDictionary = new Dictionary<string, int>();

            cDictionary.Add("zero", 10);
            cDictionary.Add("one", 60);
            cDictionary.Add("two", 30);
            cDictionary.Add("three", 40);
            cDictionary.Add("four", 50);
            cDictionary.Add("five", 80);
            cDictionary.Add("six", 20);
        }

        public DataDictionary()
        {
            SampleDictionary();
        }

        public IEnumerable<KeyValuePair<string, int>> SumList { get; set; }

    }
}
