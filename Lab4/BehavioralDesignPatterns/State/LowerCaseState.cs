using System.Globalization;

namespace BehavioralDesignPatterns.State;

public class LowerCaseState : IWritingStyleState
{
    public string Write(string message)
    {
        return message.ToLower(CultureInfo.InvariantCulture);
    }
}