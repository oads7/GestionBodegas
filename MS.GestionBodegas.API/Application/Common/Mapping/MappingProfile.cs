using Application.DTO;
using AutoMapper;
using Domain.Entities;
using System.Reflection;


namespace Application.Common.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();
            CreateMap<Warehouse, WarehouseDTO>();
            CreateMap<WarehouseDTO, Warehouse>();
            CreateMap<ProductState, ProductStateDTO>();
        }
    }
}
