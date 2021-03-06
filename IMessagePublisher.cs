using System.Threading.Tasks;

namespace Biomee.Infra.Messaging
{
    public interface IMessagePublisher
    {
        /// <summary>
        /// Publish a message.
        /// </summary>
        /// <param name="messageType">Type of the message.</param>
        /// <param name="message">The message to publish.</param>
        /// <param name="routingKey">The routingkey to use (RabbitMQ / AWS SNS/ Apache Kafka).</param>
        Task PublishMessageAsync(string messageType, object message, string routingKey);
    }
}