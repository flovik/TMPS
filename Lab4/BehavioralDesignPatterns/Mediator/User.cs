namespace BehavioralDesignPatterns.Mediator;

public class User
{
    public string Name { get; set; }
    protected readonly IEmailMediator EmailMediator;

    public User(string name, IEmailMediator emailMediator)
    {
        Name = name;
        EmailMediator = emailMediator;
    }

    public void SendEmail(string message)
    {
        Console.WriteLine($"{Name} user is sending an email to other registered" +
                          $" users. Message: {message}");
        EmailMediator.SendEmail(message, this);
    }

    public void ReceiveEmail(string message, string username)
    {
        Console.WriteLine($"Hi, {Name}! You received a new email from {username}");
        Console.WriteLine(message);
    }
}