using System;
using Microsoft.EntityFrameworkCore;

namespace OpenTelemetryAspnet.Models
{
    public class Database : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                //.UseSqlite("Data Source=database.db")
                .UseSqlServer("server=localhost,11433;database=dogs;user=sa;password=Pass123!;")
                ;
        }

        public DbSet<Dog> Dogs { get; set; }
    }

    public class Dog
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public DateTime Received { get; set; } = DateTime.Now;
    }
}