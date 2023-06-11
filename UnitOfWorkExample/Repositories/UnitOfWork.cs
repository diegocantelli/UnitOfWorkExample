using UnitOfWorkExample.Interfaces;

namespace UnitOfWorkExample.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Dictionary<Type, object> _repositories = new ();

        // Caso já exista uma chave no dicionário do mesmo tipo passado no tipo genérico do método,
        // irá retornar a instancia ja criada
        public IRepository<T> Repository<T>() where T : class
        {
            if (_repositories.ContainsKey(typeof(T)))
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
            _repositories.Clear();
        }
    }
}