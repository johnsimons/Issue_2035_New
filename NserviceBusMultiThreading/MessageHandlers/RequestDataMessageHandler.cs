using System;
using Messages.Commands;

namespace NserviceBusMultiThreading.MessageHandlers
{
    public class RequestDataMessageHandler : CommandHandler<RequestDataMessage>
    {
        protected override void OnProcess(RequestDataMessage command)
        {
            Console.WriteLine("Received Order - OrderId: {0}", command.Id);
        }
    }
}
