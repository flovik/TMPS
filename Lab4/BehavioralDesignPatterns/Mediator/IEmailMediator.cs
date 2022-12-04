namespace BehavioralDesignPatterns.Mediator;

public interface IEmailMediator
{
    void SendEmail(string message, User user);
    void AddUser(User user);
}