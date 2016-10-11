using RepositoryWithNinject.Model;

namespace RepositoryWithNinject.DAL
{
    public interface IRepository<T> where T : class
    {
        Employee Save(T entity);
        Employee Update(T entity);

    }
}
