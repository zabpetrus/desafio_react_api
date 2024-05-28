using backend.Domain.Entities;
using backend.Domain.RepositoryInterfaces;
using backend.InfraData.Context;
using backend.InfraData.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace backend.Test.UnitTests
{
    public class ProductRepositoryTest
    {

        private readonly backendApiContext _context;

       
        public ProductRepositoryTest()
        {
            var options = new DbContextOptionsBuilder<backendApiContext>()
            .UseSqlite("data source=J:\\desafio\\backend\\backend.InfraData\\Databases\\InfraDatabase.db")
            .Options;

            _context = new backendApiContext(options);
        }


        [Fact]
        public void RepositoryAddProductTest()
        {
            //Teste de  int AddProduct(Product product);

            Product product = new Product(1, "Sapato de couro", "Sapato resistente de Courino", 125.66m);

            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(o => o.AddProduct(product)).Returns(1);

            ProductRepository productRepository = new ProductRepository(mock.Object, _context);
            var result = productRepository.AddProduct(product);

            Assert.Equal(1, result);

        }


        [Fact]
        public void RepositoryGetProductByIdTest()
        {
            //Teste de int Product GetProductById(int id);

            int id = 1;
            Product product = new Product(1, "Sapato de couro", "Sapato resistente de Courino", 125.66m);

            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(o => o.GetProductById(id)).Returns(product);

            ProductRepository productRepository = new ProductRepository(mock.Object, _context );
            var result = productRepository.GetProductById(id);

            Assert.Equal(product, result);
        }

        [Fact]
        public void RepositoryGetAllProductsTest()
        {
            //Teste de List<Product> GetAllProducts();

            List<Product> products = new List<Product>();   
            Product product = new Product(1, "Sapato de couro", "Sapato resistente de Courino", 125.66m);
            products.Add(product);


            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(o => o.GetAllProducts()).Returns(products);

            ProductRepository productRepository = new ProductRepository(mock.Object, _context);
            var result = productRepository.GetAllProducts();

            Assert.Equal(products, result);
        }

        [Fact]
        public void RepositoryUpdateProductTest()
        {
            //Teste de int UpdateProduct(Product product);

            Product product = new Product(1, "Sapato de couro azul", "Sapato resistente de Courino", 125.66m);

            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(o => o.UpdateProduct(product)).Returns(1);

            ProductRepository productRepository = new ProductRepository(mock.Object, _context);
            var result = productRepository.UpdateProduct(product);

            Assert.Equal(1, result);
        }

        [Fact]
        public void RepositoryDeleteProductTest()
        {
            //Teste de int DeleteProduct(int id);;

            int id = 1;

            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(o => o.DeleteProduct(id)).Returns(1);

            ProductRepository productRepository = new ProductRepository(mock.Object, _context);
            var result = productRepository.DeleteProduct(id);

            Assert.Equal(1, result);
        }

    }
}
