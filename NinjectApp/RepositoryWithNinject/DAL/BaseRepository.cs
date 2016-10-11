using RepositoryWithNinject.Model;

namespace RepositoryWithNinject.DAL
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private IConnection _conn;
        public BaseRepository(IConnection conn)
        {
            _conn = conn;
            _conn.Create();
        }
        public Employee Save(T entity)
        {
            var emp = entity as Employee;
            emp.Status = "Saved";
            return emp;
        }
        public Employee Update(T entity)
        {
            return entity as Employee;
        }
    }
}
