using ManualInjection.Model;

namespace ManualInjection.DAL
{
    public interface IRepository<T> where T : Employee
    {
        Employee Save(T entity);
        Employee Update(T entity);

    }
}
