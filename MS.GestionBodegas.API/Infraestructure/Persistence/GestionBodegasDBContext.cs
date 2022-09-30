using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Persistence
{
    public class GestionBodegasDBContext : DbContext 
    {
        public GestionBodegasDBContext()
        { }
        public GestionBodegasDBContext(DbContextOptions<GestionBodegasDBContext> options) : base(options)
        { }

        DbSet<Product> Product { get; set; }
        DbSet<Warehouse> Warehouse { get; set; }
        DbSet<ProductState> ProductState { get; set; }

    }
}
