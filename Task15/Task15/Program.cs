using System;
using System.Diagnostics;

class Program
{
    static void newArrayX(int x)
    {
        int cnt = 0;
        int Size = new Random().Next(10_000_000, 15_000_001);
        int[] array = new int[Size];
        for (int i = 0; i < Size; i++)
        {
            array[i] = new Random().Next(0, 1001);
        }
        Array.Sort(array);
        foreach (var item in array)
        {
            if (item == x)
                cnt++;
        }
    }

    static void Main(string[] args)
    {
        long MaxTime = long.MinValue;
        long MinTime = long.MaxValue;
        long Sum = 0;
        Thread[] thread = new Thread[10];
        int x = 500;

        for (int i = 0; i < 10; i++) 
        {
            thread[i] = new Thread(() =>
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                newArrayX(x);
                sw.Stop();
                MaxTime = Math.Max(sw.ElapsedMilliseconds, MaxTime);
                MinTime = Math.Min(sw.ElapsedMilliseconds, MinTime);
                Sum += sw.ElapsedMilliseconds;

            });
            thread[i].Start();
        }
        for (int i = 0; i < 10; i++)
        {
            thread[i].Join();
        }

        double AvgTime = Sum / 10_000.0;
        Console.WriteLine($"min {MinTime / 1000.0} s");
        Console.WriteLine($"max {MaxTime / 1000.0} s");
        Console.WriteLine($"avg {AvgTime} s");
    }


}
