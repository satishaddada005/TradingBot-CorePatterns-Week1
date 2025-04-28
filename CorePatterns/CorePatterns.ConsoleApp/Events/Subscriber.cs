using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePatterns.ConsoleApp.Events
{
    public class Subscriber
    {
        public void Subscribe(Notifier notifier)
        {
            notifier.OnNotify += (msg) => Console.WriteLine($"Received : {msg}");
        }
    }
}
