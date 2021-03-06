using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ChartjsTest
{
    public class ChartJson
    {
        public string type { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public IEnumerable<string> labels { get; set; }
        public Dataset[] datasets { get; set; }
    }

    public class Dataset
    {
        public string label { get; set; }
        public IEnumerable<int> data { get; set; }
        public string backgroundColor { get; set; }
        public string borderColor { get; set; }
        public int borderWidth { get; set; }
    }
}
