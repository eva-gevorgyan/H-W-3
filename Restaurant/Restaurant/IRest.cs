using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal interface IRest
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public double Rating { get; set; }
        //public string Food { get; set; }
        public void AboutRest();
        public void SpecialOrder(string p, string w)
        {
            
        }
    }
}
