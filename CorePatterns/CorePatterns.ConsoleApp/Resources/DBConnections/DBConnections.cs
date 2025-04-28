using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePatterns.ConsoleApp.Resources.DBConnections
{
    public class DBConnections : IDisposable
    {
        private bool _disposed = false;
        public void OpenConnection()
        {
            Console.WriteLine("Connection opened");
        }

        public void CloseConnection()
        {
            Console.WriteLine("Connection Closed");
        }
        public void Dispose() 
        {
            if (!_disposed)
            {
                CloseConnection();
                _disposed = true;
            }
            
        }
    }
}
