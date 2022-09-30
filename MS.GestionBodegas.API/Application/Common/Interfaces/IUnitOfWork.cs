using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IUnitOfWork
    {
        public IRepository<Product> Product { get; }
        public IRepository<ProductState> ProductState { get; }
        public IRepository<Warehouse> Warehouse { get; }
    }
}
