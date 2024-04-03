using Microsoft.Extensions.Caching.Memory;

namespace GenericRepository.Repository
{
    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetById(int id);   

        void Create(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete (int id);

    }
}
