using NsqCli;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Consumer for each topic/channel
            var consumer = new Consumer("test-topic-name", "channel-name");
            consumer.AddHandler(new MessageHandler());
            consumer.ConnectToNsqLookupd("127.0.0.1:4161", "127.0.0.1:7161");
            //consumer.ConnectToNsqd("127.0.0.1:4150");
            Console.WriteLine("Listening for messages. If this is the first execution, it " +
                              "could take up to 60s for topic producers to be discovered.");
            Console.WriteLine("Press enter to stop...");
            Console.ReadLine();

            consumer.Stop();
        }
    }
}
