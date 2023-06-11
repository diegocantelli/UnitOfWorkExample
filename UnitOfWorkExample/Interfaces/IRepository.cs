namespace UnitOfWorkExample.Interfaces
{
    public interface IRepository<T> where T : class 
    {
        T Get(int id);
        List<T> GetAll();
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
    
}