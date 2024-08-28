using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Class2: Class1
    {
        public override void Virtual()
        {
            Console.WriteLine("Me go from Virtual");
        }

        public override void UVirtual()
        {
            Console.WriteLine("Me go from Abstract");
        }
    }
}
