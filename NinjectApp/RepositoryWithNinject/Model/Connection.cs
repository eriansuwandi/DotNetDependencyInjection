using System;
using RepositoryWithNinject.DAL;

namespace RepositoryWithNinject.Model
{
    public class Connection : IConnection
    {
        static Connection _connection;
        static int _counter = 0;
        public Connection()
        {
            _counter++;
            Console.WriteLine("Object instance class Connection " + _counter);
        }

        public static Connection GetInstance()
        {
            return _connection ?? (_connection = new Connection());
        }

        public void Create()
        {
            Console.WriteLine("Creating connection");
        }

    }
}