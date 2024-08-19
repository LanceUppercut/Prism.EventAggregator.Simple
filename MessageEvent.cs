using Prism.Events;

namespace PrismExample.EventAggregator.HelloWorld
{
    /// <summary>
    /// Simple event with string payload to publish & subscribe to
    /// </summary>
    public class MessageEvent : PubSubEvent<string> { }
}
