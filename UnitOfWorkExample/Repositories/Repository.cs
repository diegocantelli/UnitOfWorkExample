using UnitOfWorkExample.Interfaces;

namespace UnitOfWorkExample.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly List<T> _dataStore = new List<T>();

        public void Add(T entity)
        {
            _dataStore.Add(entity);
        }

        public void Delete(T entity)
        {
            _dataStore.Remove(entity);
        }

        public T Get(int id)
        {
            return _dataStore[id];
        }

        public List<T> GetAll()
        {
            return _dataStore;
        }

        public void Insert(T entity)
        {
            _dataStore.Add(entity);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}