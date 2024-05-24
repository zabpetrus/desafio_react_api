using backend.Domain.Entities;
using backend.Domain.Interfaces;
using backend.Domain.Services;
using backend.InfraData.Interfaces;
using backend.InfraData.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace backend.Test.UnitTests
{
    public class ProductRepositoryTest
    {

        [Fact]
        public void RepositoryAddProductTest()
        {
            //Teste de  int AddProduct(Product product);

            Product product = new Product(1, "Sapato de couro", "Sapato resistente de Courino", 125.66m);

            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(o => o.AddProduct(product)).Returns(1);

            ProductRepository productRepository = new ProductRepository(mock.Object);
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

            ProductRepository productRepository = new ProductRepository(mock.Object);
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

            ProductRepository productRepository = new ProductRepository(mock.Object);
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

            ProductRepository productRepository = new ProductRepository(mock.Object);
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

            ProductRepository productRepository = new ProductRepository(mock.Object);
            var result = productRepository.DeleteProduct(id);

            Assert.Equal(1, result);
        }

    }
}
