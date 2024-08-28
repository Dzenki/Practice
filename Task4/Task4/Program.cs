using System;
using Task4;

class Program 
{
    static void Main(string[] args)
    {
        int size = Convert.ToInt32(Console.ReadLine());
        Class2[] class2 = new Class2[size];
        Class2[] class2s = new Class2[size];
        Random randomm = new Random();

        for (int i = 0; i < size; i++)
        {
            class2[i] = new Class2("Element" + i, randomm.Next() == 0);
            class2s[i] = new Class2("Element" + i, randomm.Next() == 0);
        }

        int countFalse1 = class2.Count(item => !item.IsStatic);
        int countFalse2 = class2s.Count(item => !item.IsStatic);

        Console.WriteLine($"Чаще всего значение false встречается в массиве {(countFalse1 > countFalse2 ? "первом" : (countFalse1 < countFalse2 ? "втором" : "обоих"))}.");

    }
}