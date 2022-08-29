using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string website { get; set; }
        public CompanyManager Manager { get; set; }

        public string Print()
        {
            return $"Name={Name} , Address={Address} , Phone={Phone} , website={website}, Manager={Manager.Print()}";
        }
    }
}
