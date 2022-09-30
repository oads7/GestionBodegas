using Application.Common.Interfaces;
using Application.DTO;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Warehouses
{
    public class WarehousesQuery
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly IMapper Mapper;

        public WarehousesQuery(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }

        public async Task<IEnumerable<WarehouseDTO>> GetAllWarehouses()
        {
            IEnumerable<Product> products = await UnitOfWork.Product.GetAllByLambda(product => product.Active);
            return Mapper.Map<IEnumerable<WarehouseDTO>>(products);
        }

    }
}
