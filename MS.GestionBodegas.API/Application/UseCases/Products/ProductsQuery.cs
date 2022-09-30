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
    public class ProductsQuery
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly IMapper Mapper;

        public ProductsQuery(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            IEnumerable<Product> products = await UnitOfWork.Product.GetAllByLambda(product => product.Active);
            return Mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProducts(int warehouseId)
        {
            IEnumerable<Product> products;
            if (warehouseId > 0)
                products = await UnitOfWork.Product.GetAllByLambda(product => product.WarehouseId == warehouseId &&
                                                                              product.Active);
            else
                products = await UnitOfWork.Product.GetAllByLambda(product => product.Active);

            return Mapper.Map<IEnumerable<ProductDTO>>(products);
        }
    }
}
