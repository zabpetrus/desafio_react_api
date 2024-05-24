using AutoMapper;
using backend.Application.ViewModel;
using backend.Domain.Entities;
using backend.InfraData.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Test.IntegrationTests
{
    public class ProductsMappingTest
    {
        private readonly IMapper _mapper;

        public ProductsMappingTest()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductsProfile>();
            });

            _mapper = config.CreateMapper();

        }


        [Fact]
        public void Test1()
        {
            // Arrange
            var product = new Product(1, "Sapato de couro", "Sapato resistente de Courino", 125.66m);

            // Act
            var productViewModel = _mapper.Map<ProductViewModel>(product);

            // Assert
            Assert.NotNull(productViewModel);
            Assert.Equal(product.name, productViewModel.Name);
            Assert.Equal(product.description, productViewModel.Description);
            Assert.Equal(product.price, productViewModel.Price);

        }
    }
}
