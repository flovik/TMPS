namespace BehavioralDesignPatterns.Mediator;

public class EmailMediator : IEmailMediator
{
    private readonly ISet<User> Users = new HashSet<User>();
    public void SendEmail(string message, User user)
    {
        foreach (var us in Users)
        {
            if (us != user) us.ReceiveEmail(message, user.Name);
        }
    }

    public void AddUser(User user)
    {
        if (!Users.Contains(user)) Users.Add(user);
    }
}