namespace PrismExample.EventAggregator.HelloWorld
{
    /// <summary>
    /// Publishes <see cref="MessageEvent"/> using <see cref="EventAggregatorWrapper"/>
    /// </summary>
    public class MessageSender
    {
        public void SendMessage(string? message)
        {
            EventAggregatorWrapper.Aggregator.GetEvent<MessageEvent>().Publish(message ?? "Empty Message");
        }
    }
}
