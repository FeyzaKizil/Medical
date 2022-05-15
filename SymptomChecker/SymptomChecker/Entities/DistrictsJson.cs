using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymptomChecker.Entities
{
    public class DistrictsJson
    {
        public bool success { get; set; }
        public List<District> result { get; set; }
    }

    public class District
    {
        public string text { get; set; }
        public string pharmacy_number { get; set; }
        public override string ToString()
        {
            return text;
        }
    }
}
