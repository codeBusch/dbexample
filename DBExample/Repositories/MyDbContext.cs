using System;
using DBExample.Entities;
using Microsoft.EntityFrameworkCore;

namespace DBExample.Repositories
{
	public class MyDbContext:DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString: "Server=localhost;Database=ExampleDb;User Id=SA;TrustServerCertificate=True;Password=reallyStrongPwd123;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Jobber> Jobbers { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<Student> Students { get; set; }

 

    }
}

