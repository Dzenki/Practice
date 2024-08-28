using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal class Class1
    {
        public delegate void Event(int i);
        public event Event MyEvent;

        public void Eeeevent(int i)
        {
            MyEvent?.Invoke(i);
        }
    }
}
