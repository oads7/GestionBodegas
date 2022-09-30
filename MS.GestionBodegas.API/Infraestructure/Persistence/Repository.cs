using Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Persistence
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private GestionBodegasDBContext Context;
        private DbSet<TEntity> dbSet;

        public Repository(GestionBodegasDBContext context)
        {
            Context = context;
            dbSet = context.Set<TEntity>();
        }

        #region Reading Section

        public async Task<TEntity?> GetByLambda(Expression<Func<TEntity, bool>> lambda) =>
            await dbSet.FirstOrDefaultAsync(lambda);

        public async Task<IEnumerable<TEntity>> GetAllByLambda(Expression<Func<TEntity, bool>> lambda) =>
            await dbSet.Where(lambda).ToListAsync();

        #endregion

        #region Writing Section

        public async void Add(TEntity data) => 
            await dbSet.AddAsync(data);

        public void Update(TEntity entity) =>
            Context.Update(entity);

        public async Task<int> Save() =>
            await Context.SaveChangesAsync();

        #endregion

        #region Deleting Section

        public async Task DeleteByLambda(Expression<Func<TEntity, bool>> lambda) =>
            Context.Entry(await dbSet.Where(lambda).FirstOrDefaultAsync()).State = EntityState.Deleted;

        public async Task DeleteAllByLambda(Expression<Func<TEntity, bool>> lambda)
        {
            IEnumerable<TEntity> list = await dbSet.Where(lambda).ToListAsync();
            foreach (TEntity item in list)
                Context.Entry(item).State = EntityState.Deleted;
        }

        #endregion

    }
}
