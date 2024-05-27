using backend.Application.AppService;
using backend.Application.Interfaces;
using backend.Application.ViewModel;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace backend.Test.UnitTests
{
    public class ProductAppServiceTest 
    {
        
        [Fact]
        public void AppServiceGetAllProductsTests()
        {
            //Teste de List<ProductViewModel> GetAllProducts();

            // Arrange
            List<ProductViewModel> produtos = new List<ProductViewModel>
            {
                new ProductViewModel("Sapato de couro", "Sapato resistente de Courino", 125.66m)
            };

            Mock<IProductAppService> mock = new Mock<IProductAppService>();
            mock.Setup(o => o.GetAllProducts()).Returns(produtos);

            // Act
            ProductAppService productAppService = new ProductAppService(mock.Object);
            var result = productAppService.GetAllProducts();

            // Assert
            Assert.Equal(produtos, result);

        }


        [Fact]
        public void AppServiceGetProductByIdTests()
        {
            int id = 1;
            var productViewModel = new ProductViewModel("Sapato de couro", "Sapato resistente de Courino", 125.66m);

            //Teste de ProductViewModel GetProductById(int id);
            Mock<IProductAppService> mock = new Mock<IProductAppService>();
            mock.Setup(o => o.GetProductById(id)).Returns(productViewModel);

            ProductAppService productAppService = new ProductAppService(mock.Object);
            var result = productAppService.GetProductById(id);

            Assert.Equal(productViewModel, result);

        }

        [Fact]
        public void AppServiceCreateNewProductTests()
        {
            // Teste de int CreateNewProduct(ProductViewModel product);
            var productViewModel = new ProductViewModel("Sapato de couro", "Sapato resistente de Courino", 125.66m);

            Mock<IProductAppService> mock = new Mock<IProductAppService>();
            mock.Setup(o => o.CreateNewProduct(productViewModel)).Returns(1);

            ProductAppService productAppService = new ProductAppService(mock.Object);
            var result = productAppService.CreateNewProduct(productViewModel);

             Assert.Equal(1, result);

        }

        [Fact]
        public void AppServiceUpdateProductTest()
        {
            //Teste de int UpdateProduct(int id, ProductViewModel product);

            int id = 1;
            ProductViewModel productViewModel = new ProductViewModel("Sapato de couro", "Sapato resistente de Courino", 125.66m);

            Mock<IProductAppService> mock = new Mock<IProductAppService>();
            mock.Setup(o => o.UpdateProduct(id, productViewModel)).Returns(1);

            ProductAppService productAppService = new ProductAppService(mock.Object);
            var result = productAppService.UpdateProduct(id, productViewModel);

            Assert.Equal(1, result);

        }

        [Fact]
        public void AppServiceDeleteProductsTest()
        {
            //Teste de int DeleteProductById(int id);
            int id = 1;

            //Teste de ProductViewModel GetProductById(int id);
            Mock<IProductAppService> mock = new Mock<IProductAppService>();
            mock.Setup(o => o.DeleteProductById(id)).Returns(1);

            ProductAppService productAppService = new ProductAppService(mock.Object);
            var result = productAppService.DeleteProductById(id);

            Assert.Equal(1, result);
        }


    }
}
