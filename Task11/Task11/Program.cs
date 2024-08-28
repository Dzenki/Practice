using System;
using Task11;

class Program
{
    static void Main(string[] args)
    {
        Class1 class1 = new Class1();
        class1.MyEvent += Eh;
        class1.Eeeevent(2);
    }

    public static void Eh(int i)
    {
        Console.WriteLine($"method Eh {i}");
    }
}