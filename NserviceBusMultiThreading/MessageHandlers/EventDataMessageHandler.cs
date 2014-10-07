using BAL;
using Common.Interface;
using Messages.Events;
using NServiceBus;
using NServiceBus.Logging;
using NServiceBus.ObjectBuilder;

namespace NserviceBusMultiThreading.MessageHandlers
{
    public class EventDataMessageHandler : CommandHandler<IEventDataMessage>
    {
        public IReadDemo order { get; set; }

        public IClassBuilder Builder { get; set; }

        private ILog log = LogManager.GetLogger(typeof (EventDataMessageHandler));

        protected override void OnProcess(IEventDataMessage message)
        {
            var order2 = (IReadDemo)Builder.Build(typeof(IReadDemo));

            if (order.Number != order2.Number)
            {
                log.InfoFormat("ReadDemo.Initialise Not the same, {0}-{1}", order.Number, order2.Number);
                
            }
            
            
            log.InfoFormat("ReadDemo.Initialise, {0}", order.Number);

            order.Initialise(message.Id);
            // will cause a problem as well
            //var order2 = Builder.Build<IReadDemo>();
            //order2.Initialise(message.Id);
        }
    }
}
