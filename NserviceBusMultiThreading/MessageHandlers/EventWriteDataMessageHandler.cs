using BAL;
using Messages.Events;

namespace NserviceBusMultiThreading.MessageHandlers
{
    public class EventWriteDataMessageHandler : CommandHandler<IEventDataMessage>
    {
        public IWriteDemo Order { get; set; }

        protected override void OnProcess(IEventDataMessage message)
        {
            Order.Initialise(message.Id);
        }
    }
}
