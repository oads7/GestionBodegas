using Application.Common.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private GestionBodegasDBContext Context;

        public UnitOfWork(GestionBodegasDBContext context)
        {
            Context = context;
        }

        // Repository Units
        private IRepository<Product> _product;
        private IRepository<ProductState> _productState;
        private IRepository<Warehouse> _warehouse;

        // Singleton Instances
        public IRepository<Product> Product
        {
            get
            {
                return _product == null ? _product = new Repository<Product>(Context) : _product;
            }
        }

        public IRepository<ProductState> ProductState
        {
            get
            {
                return _productState == null ? _productState = new Repository<ProductState>(Context) : _productState;
            }
        }

        public IRepository<Warehouse> Warehouse
        {
            get
            {
                return _warehouse == null ? _warehouse = new Repository<Warehouse>(Context) : _warehouse;
            }
        }
    }
}
