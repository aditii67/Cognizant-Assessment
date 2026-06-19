using System;

namespace SingletonPatternExample
{
    public class Logger
    {
        private static readonly Logger instance = new Logger();

        private Logger()
        {
            Console.WriteLine("Logger initialized successfully.");
        }

        public static Logger GetInstance()
        {
            return instance;
        }

        public void Log(string message)
        {
            Console.WriteLine("[LOG] " + message);
        }
    }
}
