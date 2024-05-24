using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using backend.Domain.Entities;

    public class DefaultContextApi : DbContext
    {
        public DefaultContextApi (DbContextOptions<DefaultContextApi> options)
            : base(options)
        {
        }

        public DbSet<backend.Domain.Entities.Product> Product { get; set; } = default!;
    }
