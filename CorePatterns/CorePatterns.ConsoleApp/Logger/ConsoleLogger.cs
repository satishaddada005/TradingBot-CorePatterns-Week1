using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePatterns.ConsoleApp.Logger
{
    public class ConsoleLogger : ILogger
    {
        public ConsoleLogger() { }

        public void Log(string message) 
        {
            Console.WriteLine(message);
        }
    }
}
