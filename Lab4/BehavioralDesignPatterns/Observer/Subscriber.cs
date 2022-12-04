namespace BehavioralDesignPatterns.Observer;

public class Subscriber : ISubscriber
{
    public string Name { get; set; }
    private IPublisher _group;

    public Subscriber(IPublisher group, string name)
    {
        _group = group;
        _group.RegisterSubscriber(this);
        Name = name;
    }
    public void Update(Post state)
    {
        Console.WriteLine($"Post \"{state.Header}\" appeared on: {state.Date} ");
        Console.WriteLine(state.Body);
    }

    public void UnSubscribe()
    {
        _group.RemoveSubscriber(this);
        _group = null!;
    }
}