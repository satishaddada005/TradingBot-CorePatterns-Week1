using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePatterns.ConsoleApp.Logger
{
    public class Application
    {
        private ILogger _logger;
        private string _message;
        public Application(ILogger logger, string message) 
        {
            _logger = logger;
            _message = message;
        }

        public void Run()
        {
            _logger.Log(_message);
        }
    }
}
