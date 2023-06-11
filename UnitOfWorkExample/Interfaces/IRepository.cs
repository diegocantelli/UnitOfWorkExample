namespace UnitOfWorkExample.Interfaces
{
    public interface IRepository<T> where T : class 
    {
        void Add(T entity);
        T Get(int id);
        List<T> GetAll();
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
    
}