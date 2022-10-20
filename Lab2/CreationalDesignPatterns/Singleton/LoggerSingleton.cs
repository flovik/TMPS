using CreationalDesignPatterns.Singleton.Interfaces;

namespace CreationalDesignPatterns.Singleton;

public class LoggerSingleton : ILogger
{
    private static readonly Lazy<LoggerSingleton> Lazy = new(() => new LoggerSingleton());

    private LoggerSingleton()
    {
        //private constructor so no other objects create a LoggerSingleton
        //prevents creating object with new()
    }

    public static LoggerSingleton GetLogger()
    {
        //getInstance should be the only method that returns a LoggerSingleton
        return Lazy.Value;
    }

    //some business logic 
    public void WriteLogs(string message)
    {
        Console.WriteLine(message);
    }
}