using Microsoft.EntityFrameworkCore;
using System;

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
            optionsBuilder.UseSqlServer("Server=LAPTOP-UBJNU2RK;Database=MyDb;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDbContext context = new MyDbContext();
            context.Database.EnsureCreated();

            Class1 class1 = new Class1()
            {
                Value = "1"
            };
            context.Class1s.Add(class1);
            context.SaveChanges();
        }

    }
}
