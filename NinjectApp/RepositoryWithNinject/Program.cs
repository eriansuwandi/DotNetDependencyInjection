using System;
using Ninject;
using RepositoryWithNinject.DAL;
using RepositoryWithNinject.Model;

namespace RepositoryWithNinject
{
    class Program
    {
        private static IKernel _kernel;
        static void Main(string[] args)
        {
            // test for jenkins
            NinjectAppStart();
            //var conn = Connection.GetInstance();
            var emp = new Employee { Name = "Rudy" };
           // var empRepo = new EmployeeRepository(conn);
            var instance = _kernel.Get<EmployeeRepository>();
            var res = instance.Save(emp);
            Console.WriteLine("Name :" + res.Name);
            Console.WriteLine("Status :" + res.Status);
            Console.ReadLine();
        }

        static void NinjectAppStart()
        {
            _kernel = new StandardKernel();
            _kernel.Bind<IConnection>().To<Connection>();
           
        }
    }
}
