using System;

class Program
{
    static void Main(string[] args)
    {
        Thread thread = new Thread(RunLoop);
        thread.Start();
        void RunLoop()
        {
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter) { Console.WriteLine("key is pressed"); }
            }
        }
    }
}