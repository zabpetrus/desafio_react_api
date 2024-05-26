using backend.InfraData.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.InfraData.Context
{
    public class backendApiContextFactory : IDesignTimeDbContextFactory<backendApiContext>
    {
        public backendApiContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<backendApiContext>();
            optionsBuilder.UseSqlite("Data Source=ServiceDatabase.mdf");

            return new backendApiContext(optionsBuilder.Options);
        }
    }
}
