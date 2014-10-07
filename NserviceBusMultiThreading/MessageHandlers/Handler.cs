using NServiceBus;
using NServiceBus.Logging;

namespace NserviceBusMultiThreading.MessageHandlers
{
    public abstract class Handler
    {
        protected static readonly ILog Logger = LogManager.GetLogger(System.AppDomain.CurrentDomain.FriendlyName);
        public IBus Bus { get; set; }
    }
}
