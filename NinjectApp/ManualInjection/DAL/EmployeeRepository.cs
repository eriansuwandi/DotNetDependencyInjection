using ManualInjection.Model;

namespace ManualInjection.DAL
{
    public class EmployeeRepository : BaseRepository<Employee>
    {
        public EmployeeRepository(IConnection conn) : base(conn)
        {
        }

    }
}
