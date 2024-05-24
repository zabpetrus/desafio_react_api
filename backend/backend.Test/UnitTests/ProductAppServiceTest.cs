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
        public void Test1()
        {
            //Teste de List<ProductViewModel> GetAllProducts();

            List<ProductViewModel> produtos = new List<ProductViewModel>();
            produtos.Add(new ProductViewModel("Sapato de couro", "Sapato resistente de Courino", 125.66m));

            Mock<IProductAppService> mock = new Mock<IProductAppService>();
            mock.Setup(o => o.GetAllProducts()).Returns(produtos);

            //Act
            ProductAppService productAppService = new ProductAppService(mock.Object);
            var result = productAppService.GetAllProducts();    

            //Assert
            Assert.Equal(produtos, result);

        }


        [Fact]
        public void Test2()
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
        public void Test3()
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
        public void Test4()
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
        public void Test5()
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
