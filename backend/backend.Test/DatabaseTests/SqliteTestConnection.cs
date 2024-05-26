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
        public void StringConnctionTest()
        {
            // Arrange
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=J:\\desafio\\backend\\backend.InfraData\\Databases\\ServiceDatabase.mdf;Integrated Security=True";

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
