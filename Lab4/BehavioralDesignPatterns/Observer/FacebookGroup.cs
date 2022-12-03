namespace BehavioralDesignPatterns.Observer;

public class FacebookGroup : IPublisher
{
    private ISet<ISubscriber> _subscribers;
    private Post? _post; //state of the publisher

    public FacebookGroup()
    {
        _subscribers = new HashSet<ISubscriber>();
    }

    public void RegisterSubscriber(ISubscriber sub)
    {
        if (!_subscribers.Contains(sub)) _subscribers.Add(sub);
    }

    public void RemoveSubscriber(ISubscriber sub)
    {
        if (_subscribers.Contains(sub)) _subscribers.Remove(sub);
    }

    public void NotifySubscribers()
    {
        foreach (var sub in _subscribers)
        {
            sub.Update(_post!); //for every sub notify each of them
        }
    }

    public void NewPost()
    {
        _post = new Post("Chisinau is green!", "Chisinau is greener...");
        NotifySubscribers();
    }
}