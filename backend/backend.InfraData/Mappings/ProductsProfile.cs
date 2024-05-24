using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using backend.Application.ViewModel;
using backend.Domain.Entities;

namespace backend.InfraData.Mappings
{
    public class ProductsProfile : Profile
    {
        public ProductsProfile()
        {
            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductViewModel, Product>();
        }
    }
}
