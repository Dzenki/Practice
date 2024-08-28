using System;

class Program
{

    static void Main(string[] args)
    {
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            int randomm = (new Random()).Next(0, size);
            arr[i] = randomm;
        }

        Console.WriteLine($"Медианное значение {Median(arr, size)}");
    }


    static double Median(int[] arr, int size)
    {
        Array.Sort(arr);
        int mid = size / 2;

        if (size % 2 == 0)
        {
            return (arr[mid - 1] + arr[mid]) / 2;
        }
        else
        {
            return (arr[mid]);
        }
    }

}