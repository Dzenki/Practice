using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;


    public class Class1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Allergy allergy { get; set; }
    }


    public class Allergy
    {
        public int AllergyId { get; set; }
        public string AllergyName { get; set; }
    }

    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-UBJNU2RK;Database=Allergy;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Class1> Class1s { get; set; }
        public DbSet<Allergy> Allergys { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDbContext context = new MyDbContext();
            context.Database.EnsureCreated();

            Allergy apple = new Allergy {AllergyName = "Apple" };
            Allergy strawberry = new Allergy { AllergyName = "strawberry" };
            Allergy banana = new Allergy { AllergyName = "Banana" };
            context.Allergys.AddRange(apple, strawberry, banana);

            Class1 varya  = new Class1 { Name = "Varya", allergy = apple};
            Class1 varvara = new Class1 { Name = "Varya", allergy = banana };
            Class1 NEvarya = new Class1 { Name = "Ne_Varya", allergy = strawberry };
            context.Class1s.AddRange(varya, varvara, NEvarya);

            context.SaveChanges();

            var class1 = context.Class1s.ToList();
            foreach(var item in class1) 
            {
                Console.WriteLine($"{item.Name} has allergy on {item.allergy}");
            }
        }

    }