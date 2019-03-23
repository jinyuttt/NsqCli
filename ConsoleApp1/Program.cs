using NsqCli;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var producer = new Producer("127.0.0.1:4150");
            producer.Publish("test-topic-name", "Hello!");

            Console.WriteLine("Enter your message (blank line to quit):");
            string line = Console.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                producer.Publish("test-topic-name", line);
                line = Console.ReadLine();
            }

            producer.Stop();
        }
    }
}
