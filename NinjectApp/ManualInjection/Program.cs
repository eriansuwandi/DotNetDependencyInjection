using System;
using ManualInjection.DAL;
using ManualInjection.Model;

namespace ManualInjection
{
    public class Program
    {
        static void Main(string[] args)
        {
            var conn = Connection.GetInstance();
            var emp = new Employee { Name = "Rudy" };
            var empRepo = new EmployeeRepository(conn);
            var res = empRepo.Save(emp);
            Console.WriteLine("Name :" + res.Name);
            Console.WriteLine("Status :" + res.Status);
            Console.ReadLine();
        }
    }
}
