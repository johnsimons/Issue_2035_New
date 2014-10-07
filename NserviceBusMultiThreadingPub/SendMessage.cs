using System.Linq;
using Messages.Events;
using Schroders.Crpt.Qir.Model.Repository;
using System;
using NServiceBus;

namespace NserviceBusMultiThreadingPub
{
    class SendMessage : IWantToRunWhenBusStartsAndStops
    {
        public IBus Bus { get; set; }
        public IOrderRepository OrderRepository { get; set; }

        public void Start()
        {
            try
            {
                Console.WriteLine("Press 'Enter' to send a message.To exit, Ctrl + C");
                while (Console.ReadLine() != null)
                {
                    foreach (var order in OrderRepository.ListAll())
                    {
                        Bus.Publish<IEventDataMessage>(evt =>
                        {
                            evt.Id = order.OrderId;
                        });
                        Console.WriteLine("==========================================================================");
                        Console.WriteLine("Publish Order - OrderId: {0}", order.OrderId);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
        }

        public void Stop()
        {
        }
    }
}
