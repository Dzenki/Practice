using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task2
{
    public delegate void Delegate(string str);
    internal class Class1
    {
        private void Private(string str)
        {
            Console.WriteLine($"Не произноси {str}");
        }

        public Delegate Delegate { get; private set; }

        public Class1() 
        { 
            Delegate = new Delegate(Private);
        }
    }
}
