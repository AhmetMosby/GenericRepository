
namespace GenericRepository.Repository
{
    public class GenericRepository<TEntity> : IRepository<TEntity>
    {
        public void Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
