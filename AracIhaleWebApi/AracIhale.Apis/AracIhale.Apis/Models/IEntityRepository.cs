using AracIhale.Apis.Models.Entities;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System;

namespace AracIhale.Apis.Models
{
    public interface IEntityRepository<TEntity>
         where TEntity : class, IEntity, new()
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> filter = null);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        Task<IEnumerable<TEntity>> GetAllAsync();
        void Update(TEntity entity);
    }
}
