namespace Sender.Api.Helpers
{
    public interface IRabbitService
    {
        void Publish<T>(T message, string exchangeName, string exchangeType, string routeKey, string queueName)
            where T : class;
    }
}