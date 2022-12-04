namespace BehavioralDesignPatterns.State;

public class BoldCaseState : IWritingStyleState
{
    public string Write(string message)
    {
        return "**" + message + "**";
    }
}