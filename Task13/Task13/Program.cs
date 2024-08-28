using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Efffff
{
    public class Class1
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }

    public class MyDbContext : DbContext
    {
        public DbSet<Class1> Class1s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-UBJNU2RK;Database=ForkDb;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDbContext context = new MyDbContext();
            context.Database.EnsureCreated();
            Stopwatch stopwatch = new Stopwatch();
            Random randomm = new Random();

            if(!context.Class1s.Any())
            {
                for (int i = 0; i < 1_000_000; i++) 
                {
                    Class1 class11 = new Class1()
                    {
                        Value = $"{randomm.Next()}_dude"
                    };
                    context.Class1s.Add(class11);
                }
                context.SaveChanges();
            }
            int AmountOfLines = 1000;
            long Sum = 0;
            for (int i = 0; i < AmountOfLines; i++)
            {
                int IdToFind = randomm.Next(1, 1_000_001);
                stopwatch.Restart();
                context.Class1s.FirstOrDefault(x => x.Id == 10);
                stopwatch.Stop();
                Sum += stopwatch.ElapsedMilliseconds;
            }
            Console.WriteLine((double)Sum / AmountOfLines);

        }

    }
}