namespace BehavioralDesignPatterns.Observer;

public interface ISubscriber
{
    void Update(Post state);
}