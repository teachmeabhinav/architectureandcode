using System;

namespace ConsoleApp1
{
    public abstract class BaseMessageBase : IMessage
    {
        public string message { get; init; }
        public void PrintMe(string message)
        {
            Console.WriteLine($"{message}");
        }
    }
}