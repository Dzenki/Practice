using System;
using Task6;

class Program
{
    static void Main(string[] args)
    {
        Class1 a = new Class1(1, 2);
        Class1 b = new Class1(3, 4);

        Class1 c = a + b;
        Console.WriteLine($"{ c.A}, { c.B}");
    }
}