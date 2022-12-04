using System.Globalization;

namespace BehavioralDesignPatterns.State;

public class UpperCaseState : IWritingStyleState
{
    public string Write(string message)
    {
        return message.ToUpper(CultureInfo.InvariantCulture);
    }
}