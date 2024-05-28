using backend.Domain.Entities;

namespace backend.Test.UnitTests
{
    public class DomainTest
    {
        [Fact]
        public void ProductBasicPriceTest()
        {
            Product product = new Product();
            product.id = 1;
            product.name = "Sapato azul";
            product.description = "Sapato do Edson Arantes";
            product.price = 23.55m;

            Assert.Equal(23.55m, product.price);

        }

        [Fact]
        public void ProductBasicIDTest()
        {
            Product product = new Product();
            product.id = 1;
            product.name = "Sapato azul";
            product.description = "Sapato do Edson Arantes";
            product.price = 23.55m;


            Assert.Equal(1, product.id);


        }

        [Fact]
        public void ProductBasicNameTest()
        {
            Product product = new Product();
            product.id = 1;
            product.name = "Sapato azul";
            product.description = "Sapato do Edson Arantes";
            product.price = 23.55m;

            Assert.Equal("Sapato azul", product.name);


        }

        [Fact]
        public void ProductBasicDescriptionTest()
        {
            Product product = new Product();
            product.id = 1;
            product.name = "Sapato azul";
            product.description = "Sapato do Edson Arantes";
            product.price = 23.55m;

            Assert.Equal("Sapato do Edson Arantes", product.description);


        }
    }
}