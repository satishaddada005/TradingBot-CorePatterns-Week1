using CorePatterns.ConsoleApp.Events;
using CorePatterns.ConsoleApp.Logger;
using CorePatterns.ConsoleApp.Resources.DBConnections;

internal class Program
{
    public static void Main(string[] args)
    {
        ILogger logger = new ConsoleLogger();
        Application app = new Application(logger,"Logger Created");
        app.Run();

        Notifier notifier = new Notifier();
        Subscriber subscriber = new Subscriber();
        subscriber.Subscribe(notifier);
        notifier.Send("Event message: Trade Executed");

        using(var connection = new DBConnections())
        {
            connection.OpenConnection();
        }
    }
}