using Application.Common.Interfaces;
using Application.DTO;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Products
{
    public class ProductsCommand
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly IMapper Mapper;

        public ProductsCommand(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }

        public async Task SaveProduct(ProductDTO productDTO)
        {
            Product products = Mapper.Map<Product>(productDTO);
            UnitOfWork.Product.Add(products);
            await UnitOfWork.Product.Save();
            return;
        }
        
    }
}
