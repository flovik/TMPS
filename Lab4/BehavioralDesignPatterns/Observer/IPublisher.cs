namespace BehavioralDesignPatterns.Observer;

public interface IPublisher
{
    void RegisterSubscriber(ISubscriber sub);
    void RemoveSubscriber(ISubscriber sub);
    void NotifySubscribers();
}