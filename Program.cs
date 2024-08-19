using PrismExample.EventAggregator.HelloWorld;

MessageReceiver messageReceiver = new MessageReceiver();
MessageSender messageSender = new MessageSender();

while (true)
{
    Console.WriteLine("Type your message <Enter>");
    string? message = Console.ReadLine();
    messageSender.SendMessage(message);
}
