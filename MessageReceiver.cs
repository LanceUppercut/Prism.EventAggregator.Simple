using Prism.Events;

namespace PrismExample.EventAggregator.HelloWorld
{
    /// <summary>
    /// Subscribes to <see cref="MessageEvent"/> & prints message to console
    /// </summary>
    public class MessageReceiver
    {
        public MessageReceiver()
        {
            EventAggregatorWrapper.Aggregator.GetEvent<MessageEvent>().Subscribe(HandleNewMessage);
        }

        public void HandleNewMessage(string message)
        {
            Console.Write($"{Environment.NewLine}{DateTime.Now}: Received '{message}'");
            Console.WriteLine($"{Environment.NewLine}");
        }
    }
}
