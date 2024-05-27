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

            //cfg.CreateMap<Source, Destination>();

            CreateMap<Product, ProductViewModel>()
                .ForMember(des => des.Id, map => map.MapFrom(orig => orig.id))
                .ForMember(des => des.Name, map => map.MapFrom(orig => orig.name))
                .ForMember(des => des.Description, map => map.MapFrom(orig => orig.description))
                .ForMember(des => des.Price, map => map.MapFrom(orig => orig.price))
                .IncludeAllDerived();
            


            CreateMap<ProductViewModel, Product>()
                .ForMember(des => des.id, map => map.MapFrom(orig => orig.Id))
                .ForMember(des => des.name, map => map.MapFrom(orig => orig.Name))
                .ForMember(des => des.description, map => map.MapFrom(orig => orig.Description))
                .ForMember(des => des.price, map => map.MapFrom(orig => orig.Price))
                .IncludeAllDerived();
            





            AllowNullCollections = true;
        }
    }
}
