using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App001.TestAssets
{
    public class ListTestObject
    {
        public ListTestObject(string name, string logical_name)
        {
            this.name = name;
            this.logical_name = logical_name;
        }

        public ListTestObject()
        {
        }

        public string name { get; set; }
        public string logical_name { get; set; }

        public override string ToString()
        {
            return logical_name;
        }
    }
}
