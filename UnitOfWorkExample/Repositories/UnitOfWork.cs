using UnitOfWorkExample.Interfaces;

namespace UnitOfWorkExample.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private Dictionary<Type, object>? _repositories = new Dictionary<Type, object>();

        public IRepository<T> Repository<T>() where T : class
        {
            if (_repositories.ContainsKey(typeof(T)) == true)
            {
                return _repositories[typeof(T)] as IRepository<T>;
            }

            IRepository<T> repo = new Repository<T>();
            _repositories.Add(typeof(T), repo);
            return repo;
        }

        public void Save()
        {
            Console.WriteLine("Objetos salvos no banco de dados");
            // caso houvesse uma conexao real com o BD, o controle de transacao seria feito dessa forma
            // try
            // {
            //     _transaction.Commit();
            // }
            // catch
            // {
            //     _transaction.Rollback();
            //     throw;
            // }
            // finally
            // {
            //     _transaction.Dispose();
            //     _transaction = _connection.BeginTransaction();
            //     resetRepositories();
            // }
        }

        public void Dispose()
        {
            _repositories = null;
        }
    }
}