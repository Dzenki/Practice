using System;


delegate void delegate1(int num, string str, bool b);
delegate int delegate2(int[] num, double d);

class Program
{

    static void Method1(int num, string str, bool b)
    {
        Console.WriteLine($"{num}, {str}, {b}");
    }

    static int Method2(int[] num, double d)
    {
        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine($"{num[i]}, {d}");
        }
        return 0;
    }

    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };


        delegate1 delegate1 = new delegate1(Method1);
        delegate2 delegate2 = new delegate2(Method2);

        delegate1(10, "str", false);
        delegate2(array, 2.5);
    }
}