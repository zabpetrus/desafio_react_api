using backend.Domain.Context;
using Elfie.Serialization;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace backend.Test.DatabaseTests
{
    public class SqliteTestConnection
    {
        [Fact]
        public void StringConnctionTestType()
        {
            // Arrange
            string connectionString = "data source=J:\\desafio\\backend\\backend.InfraData\\Databases\\InfraDatabase.db";

            var dbOption = new DbContextOptionsBuilder<backendApiContext>()
            .UseSqlite(connectionString).Options;


            // Act & Assert
            using (backendApiContext context = new backendApiContext(dbOption))
            {
                Assert.True(context.Database.IsSqlite());
            }
        }



        [Fact]
        public void StringConnectionTestConnection()
        {
            // Determine the base path for the project
            string basePath = "data source=J:\\desafio\\backend\\backend.InfraData\\Databases\\InfraDatabase.db";

       
            var dbOption = new DbContextOptionsBuilder<backendApiContext>()
                .UseSqlite(basePath)
                .Options;

            try
            {
                // Act & Assert
                using (backendApiContext context = new backendApiContext(dbOption))
                {
                    bool canConnect = context.Database.CanConnect();
                    Assert.True(canConnect);
                }
            }
            catch (Exception ex)
            {
                // Print the exception message for debugging purposes
                Assert.Fail($"Exception occurred: {ex.Message}  ");
            }
        }




    }
}
