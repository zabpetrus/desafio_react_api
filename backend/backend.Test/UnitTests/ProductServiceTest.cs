using backend.Domain.Entities;
using backend.Domain.Interfaces;
using backend.Domain.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace backend.Test.UnitTests
{
    public class ProductServiceTest
    {
        [Fact]
        public void ServiceGetProductsTest()
        {
            //Teste de List<Product> GetProducts();

            List<Product> produtos = new List<Product>();
            produtos.Add(new Product(1, "Sapato de couro", "Sapato resistente de Courino", 125.66m));

            Mock<IProductService> mock = new Mock<IProductService>();
            mock.Setup(o => o.GetProducts()).Returns(produtos);

            //Act
            ProductService productService = new ProductService(mock.Object);
            var result = productService.GetProducts();

            //Assert
            Assert.Equal(produtos, result);

        }


        [Fact]
        public void ServiceGetProductByIdTest()
        {
            int id = 1;
            var product = new Product(1, "Sapato de couro", "Sapato resistente de Courino", 125.66m);

            //Teste de ProductViewModel GetProductById(int id);
            Mock<IProductService> mock = new Mock<IProductService>();
            mock.Setup(o => o.GetProductById(id)).Returns(product);

            ProductService productService = new ProductService(mock.Object);
            var result = productService.GetProductById(id);

            Assert.Equal(product, result);

        }

        [Fact]
        public void ServiceCreateNewProductTest()
        {
            // Teste de int CreateNewProduct(ProductViewModel product);
            var product = new Product(1, "Sapato de couro", "Sapato resistente de Courino", 125.66m);

            Mock<IProductService> mock = new Mock<IProductService>();
            mock.Setup(o => o.CreateNewProduct(product)).Returns(1);

            ProductService productAppService = new ProductService(mock.Object);
            var result = productAppService.CreateNewProduct(product);

            Assert.Equal(1, result);

        }

        [Fact]
        public void ServiceUpdateProductTest()
        {
            //Teste de int UpdateProduct(int id, ProductViewModel product);
            //Observação: Não se requer o id aqui, o processamento é no service

            Product product = new Product(1, "Sapato de couro", "Sapato resistente de Courino", 125.66m);

            Mock<IProductService> mock = new Mock<IProductService>();
            mock.Setup(o => o.UpdateProduct(product)).Returns(1);

            ProductService productService = new ProductService(mock.Object);
            var result = productService.UpdateProduct(product);

            Assert.Equal(1, result);

        }

        [Fact]
        public void ServiceDeleteProductByIdTest()
        {
            //Teste de int DeleteProductById(int id);
            int id = 1;

            //Teste de ProductViewModel GetProductById(int id);
            Mock<IProductService> mock = new Mock<IProductService>();
            mock.Setup(o => o.DeleteProductById(id)).Returns(1);

            ProductService productService = new ProductService(mock.Object);
            var result = productService.DeleteProductById(id);

            Assert.Equal(1, result);
        }


    }
}
