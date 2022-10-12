using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Singleton.Interfaces
{
    public interface ILogger
    {
        public void WriteLogs(string message);
    }
}
