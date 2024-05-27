using AutoMapper;
using backend.Application.AppService;
using backend.Application.Interfaces;
using backend.Application.ViewModel;
using backend.Domain.Entities;
using backend.Domain.Interfaces;
using backend.Domain.Services;
using backend.InfraData.Context;
using backend.InfraData.Mappings;
using Microsoft.Build.Construction;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace backend.Test.IntegrationTests
{
    //Referencia: https://medium.com/codenx/automapper-in-net-core-778f9c874164
    public class ProductViewModelinProductServicesTest
    {
        private readonly IMapper _mapper;

        public ProductViewModelinProductServicesTest()
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ProductsProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            _mapper = mapper;
        }

        [Fact]
        public void Test1()
        {
            List<Product> lista = new List<Product>();
            lista.Add(new Product(1, "Chewe", "Boneco do Chewbakka", 9.8m));

            Mock<IProductService> mock = new Mock<IProductService>();
            mock.Setup(o => o.GetProducts()).Returns(lista);

            ProductService productService = new ProductService(mock.Object);
            List<Product> ser = productService.GetProducts();

            List<ProductViewModel> destino = _mapper.Map<List<Product>, List<ProductViewModel>>(ser);

            Mock<IProductAppService> mock2 = new Mock<IProductAppService>();
            mock2.Setup(p => p.GetAllProducts()).Returns(destino);

            ProductAppService productAppService = new ProductAppService(mock2.Object);
            List<ProductViewModel> org = productAppService.GetAllProducts();

            // Assuming org and ser are lists of the same length
            for (int i = 0; i < org.Count && i < ser.Count; i++)
            {
                Assert.Equal(org[i].Id, ser[i].id);
                Assert.Equal(org[i].Name, ser[i].name);
                Assert.Equal(org[i].Description, ser[i].description);
                Assert.Equal(org[i].Price, ser[i].price);
            }
        }
    }
}
