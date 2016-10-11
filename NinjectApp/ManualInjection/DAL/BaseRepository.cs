using ManualInjection.Model;

namespace ManualInjection.DAL
{
    public class BaseRepository<T> : IRepository<T> where T : Employee
    {
        public BaseRepository(IConnection conn)
        {
            conn.Create();
        }
        public Employee Save(T entity)
        {
            var emp = entity as Employee;
            emp.Status = "Saved";
            return emp;
        }
        public Employee Update(T entity)
        {
            return entity;
        }
    }
}
