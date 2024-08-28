// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using laba1;
using System;

internal class Program
{
    public static void Main(string[] args)
    {
        Class1 a = new Class1(1, 3);
        Class1 b = new Class1(1, 2);
        Class1 c_1 = a + b;
        Console.WriteLine(c_1.ToString());
        Class1 c_2 = a - b;
        Console.WriteLine(c_2.ToString());
        Class1 c_3 = a * b;
        Console.WriteLine(c_3.ToString());
        Class1 c_4 = a / b;
        Console.WriteLine(c_4.ToString());
        Class1 c_5 = -(a / b);
        Console.WriteLine(c_5.ToString());
        bool test_1 = a > b;
        Console.WriteLine(test_1);
        bool test_2 = a < b;
        Console.WriteLine(test_2);
        bool test_3 = a >= b;
        Console.WriteLine(test_3);
        bool test_4 = a <= b;
        Console.WriteLine(test_4);
        bool test_5 = a == b;
        Console.WriteLine(test_5);
        bool test_6 = a != b;
        Console.WriteLine(test_6);
    }
}
