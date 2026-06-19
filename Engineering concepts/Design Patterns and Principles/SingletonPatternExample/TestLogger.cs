using System;

namespace SingletonPatternExample
{
    class TestLogger
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Singleton Pattern Demo =====\n");

            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            logger1.Log("Application Started");
            logger2.Log("User Logged In");

            Console.WriteLine();

            if (object.ReferenceEquals(logger1, logger2))
            {
                Console.WriteLine(" Only one Logger instance exists.");
            }
            else
            {
                Console.WriteLine("Multiple Logger instances exist.");
            }

            Console.WriteLine("\nProgram Executed Successfully.");
        }
    }
}
