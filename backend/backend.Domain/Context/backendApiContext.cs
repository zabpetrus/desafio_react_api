using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using backend.Domain.Entities;

namespace backend.Domain.Context
{
    public class backendApiContext : DbContext
    {
        public backendApiContext(DbContextOptions<backendApiContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("data source=J:\\desafio\\backend\\backend.InfraData\\Databases\\InfraDatabase.db");

    }
}
