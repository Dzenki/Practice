
using laba1_tsk2;
using System;


namespace laba1_tsk2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo myCIintL = new CultureInfo("es-US", false);

            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss A"));

            Console.WriteLine(DateTime.Now.ToString("dd MMMM yyyy"));
            // en-US  ru-RU es-ES
        }
    }
}
