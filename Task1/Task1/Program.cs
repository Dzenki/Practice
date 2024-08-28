using System;
using System.ComponentModel;
using Task1;

class Prorgam
{
    static void Main(string[] args)
    {
        int size = Convert.ToInt32(Console.ReadLine());

        Class1[] class1s = new Class1[size];

        for (int i = 0; i < size; i++)
        {
            int randomm = (new Random()).Next(100);
            class1s[i] = new Class1(randomm, $"Рандомное число_{randomm}");
        }

        foreach(var  class1 in class1s)
        {
            Console.WriteLine($"{class1.num}, {class1.name}");
        }
    }
}