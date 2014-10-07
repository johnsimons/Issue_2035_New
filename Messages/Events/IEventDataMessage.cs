using NServiceBus;

namespace Messages.Events
{
    public interface IEventDataMessage:IEvent
    {
       int Id { get; set; }
    }
}
