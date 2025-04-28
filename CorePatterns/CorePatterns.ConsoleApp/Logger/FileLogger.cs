using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePatterns.ConsoleApp.Logger
{
    public class FileLogger : ILogger
    {
        public string _filePath { get; set; }
        public FileLogger(string filePath) 
        {
            _filePath = filePath;
        }

        public void Log(string message)
        {
            List<string> messageContent = new List<string>();
            messageContent.Add(message);
            File.AppendAllLines(_filePath,messageContent);
        }
    }
}
