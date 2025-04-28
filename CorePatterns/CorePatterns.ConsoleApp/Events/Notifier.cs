using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePatterns.ConsoleApp.Events
{
    public class Notifier
    {
        public Notifier() { }

        public event Action<string> OnNotify;

        public void Send(string message)
        {
            OnNotify?.Invoke(message);
        }

    }
}
