using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Class1
    {
        public int A { get; set; }
        public int B { get; set; }

        public Class1(int A, int B)
        {
            this.A = A; 
            this.B = B;
        }

        public static Class1 operator +(Class1 first, Class1 second)
        {
            return new Class1(first.A + second.A, first.B + second.B);
        }
    }
}
