namespace BehavioralDesignPatterns.State;

public class DefaultState : IWritingStyleState
{
    public string Write(string message)
    {
        return message;
    }
}