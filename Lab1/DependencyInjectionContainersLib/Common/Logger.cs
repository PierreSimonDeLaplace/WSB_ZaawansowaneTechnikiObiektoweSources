using System;

namespace DependencyInjectionContainersLib.Common
{
    public class Logger : ILogger
    {
        public void Log(string msg) => Console.WriteLine($"{DateTime.Now}|{msg}");
    }
}
