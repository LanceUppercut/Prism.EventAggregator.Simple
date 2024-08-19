using Prism.Events;

namespace PrismExample.EventAggregator.HelloWorld
{
    /// <summary>
    /// Wrapper class around <see cref="IEventAggregator"/> as this simple demo is 
    /// not using DI container
    /// </summary>
    public class EventAggregatorWrapper
    {
        public static readonly IEventAggregator Aggregator;

        static EventAggregatorWrapper() => Aggregator = new Prism.Events.EventAggregator();
    }
}
