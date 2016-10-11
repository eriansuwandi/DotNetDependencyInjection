using RepositoryWithNinject.Model;

namespace RepositoryWithNinject.DAL
{
    public class EmployeeRepository : BaseRepository<Employee>
    {
        public EmployeeRepository(IConnection conn) : base(conn)
        {
        }

    }
}
