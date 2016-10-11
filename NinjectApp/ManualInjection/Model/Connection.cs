using System;
using ManualInjection.DAL;

namespace ManualInjection.Model
{
    public class Connection : IConnection
    {
        static Connection _connection;
        static int counter = 0;
        public Connection()
        {
            Connection.counter++;
            Console.WriteLine("Object instance class Connection ke " + Connection.counter);
        }

        public static Connection GetInstance()
        {

            if (Connection._connection == null)
            {
                Connection._connection = new Connection();
            }

            return Connection._connection;
        }

        public void Create()
        {
            Console.WriteLine("Creating connection");
        }

    }
}
