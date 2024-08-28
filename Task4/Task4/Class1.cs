using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Class1
    {
        public string Name { get; set; }
        public bool IsStatic { get; set; }

        public Class1(string Name, bool IsStatic) 
        {
            this.Name = Name;
            this.IsStatic = IsStatic;
        }
    }
}
