using backend.Domain.Entities;

namespace backend.Test
{
    public class DomainTest
    {
        [Fact]
        public void Test1()
        {
            Product product = new Product();
            product.id = 1;
            product.name = "Sapato azul";
            product.description = "Sapato do Edson Arantes";
            product.price = 23.55m;

            Assert.Equal(23.55m, product.price);

        }

        [Fact]
        public void Test2()
        {
            Product product = new Product();
            product.id = 1;
            product.name = "Sapato azul";
            product.description = "Sapato do Edson Arantes";
            product.price = 23.55m;


            Assert.Equal(1, product.id);
            

        }

        [Fact]
        public void Test3()
        {
            Product product = new Product();
            product.id = 1;
            product.name = "Sapato azul";
            product.description = "Sapato do Edson Arantes";
            product.price = 23.55m;
            
            Assert.Equal("Sapato azul", product.name);
           

        }

        [Fact]
        public void Test4()
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