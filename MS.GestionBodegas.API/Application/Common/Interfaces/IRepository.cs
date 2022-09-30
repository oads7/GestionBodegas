using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity?> GetByLambda(Expression<Func<TEntity, bool>> lambda);
        Task<IEnumerable<TEntity>> GetAllByLambda(Expression<Func<TEntity, bool>> lambda);
        void Add(TEntity data);
        void Update(TEntity entity);
        Task<int> Save();
        Task DeleteByLambda(Expression<Func<TEntity, bool>> lambda);
        Task DeleteAllByLambda(Expression<Func<TEntity, bool>> lambda);
    }
}
