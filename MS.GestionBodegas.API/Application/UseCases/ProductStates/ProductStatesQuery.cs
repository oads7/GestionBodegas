using Application.Common.Interfaces;
using Application.DTO;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.ProductStates
{
    public class ProductStatesQuery
    {
        private readonly IUnitOfWork UnitOfWork;
        private readonly IMapper Mapper;

        public ProductStatesQuery(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }

        public async Task<IEnumerable<ProductStateDTO>> GetAllStates()
        {
            IEnumerable<ProductState> states = await UnitOfWork.ProductState.GetAllByLambda(product => true);
            return Mapper.Map<IEnumerable<ProductStateDTO>>(states);
        }
    }
}
