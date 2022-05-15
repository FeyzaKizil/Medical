using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymptomChecker.Entities
{
    public class PharmacyJson
    {

        public bool success { get; set; }
        public List<Pharmacy> result { get; set; }
    }

    public class Pharmacy
    {
        public string name { get; set; }
        public string dist { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string loc { get; set; }

    }
}
