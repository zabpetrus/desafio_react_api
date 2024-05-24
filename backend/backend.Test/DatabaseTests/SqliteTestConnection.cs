using backend.InfraData.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace backend.Test.DatabaseTests
{
    public class SqliteTestConnection
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=J:\\desafio\\backend\\backend.InfraData\\Database.mdf;Integrated Security=True;Connect Timeout=30";

            var dbOption = new DbContextOptionsBuilder<backendApiContext>()
            .UseSqlite(connectionString).Options;


            // Act & Assert
            using (backendApiContext context = new backendApiContext(dbOption))
            {
                Assert.True(context.Database.IsSqlite());
            }
        }
    }
}
