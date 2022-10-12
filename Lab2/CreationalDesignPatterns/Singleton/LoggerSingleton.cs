using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPatterns.Singleton.Interfaces;

namespace CreationalDesignPatterns.Singleton
{
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
}

//singleton pattern ensures that a class has only one instance
//singleton is good when we should have only one instance available to all clients
//provides stricter control over global variables
//you gain global access point to that singleton instance
//singleton is created initialized only when it's requested for the first time