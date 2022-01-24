using System;

namespace CSharp8Features
{
    public class ConsoleLogging : ILogger
    {
        public void WriteInfo(string message) => Console.WriteLine(message);
    }
}
