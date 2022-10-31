using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Singleton
{
    public class User
    {
        private readonly string Name;
        private readonly string Surname;
        private readonly LoggerSingleton _logger;

        public User(LoggerSingleton logger, string name, string surname)
        {
            _logger = logger;
            Surname = surname;
            Name = name;
        }

        public void PrintToConsole()
        {
            _logger.WriteLogs($"{Name} {Surname}");
        }
    }
}
