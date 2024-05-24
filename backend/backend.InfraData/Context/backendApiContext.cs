using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using backend.Domain.Entities;

namespace backend.InfraData.Context
{
    public class backendApiContext : DbContext
    {
        public backendApiContext (DbContextOptions<backendApiContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; } = default!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=J:\\desafio\\backend\\backend.InfraData\\Database.mdf;Integrated Security=True"); // Usando a string de conexão SQLite fornecida
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().HasKey(m => m.id);
            base.OnModelCreating(builder);
        }
    }
}
