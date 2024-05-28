using backend.Domain.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Test.IntegrationTests
{
    public class DBContextDatabaseConnect
    {
        [Fact]
        public void CanConnectToDatabase()
        {
            var option = new DbContextOptionsBuilder<backendApiContext>()
                .UseInMemoryDatabase(databaseName: "testdatabase").Options;

            using (var context = new backendApiContext(option))
            {
               
            }
        }
    }
}
