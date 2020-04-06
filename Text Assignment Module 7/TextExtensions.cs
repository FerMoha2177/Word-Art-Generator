using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Assignment_Module_7
{
    public class TextExtensions
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public override string ToString() { return this.Name; }
    }
}
