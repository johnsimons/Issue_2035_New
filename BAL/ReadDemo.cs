using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Schroders.Crpt.Qir.Model.Repository;

namespace BAL
{
    public interface IReadDemo
    {
        void Initialise(int Id);
        int Number { get; }
    }

    public class ReadDemo : IReadDemo
    {
        private readonly IOrderRepository _orderRepository;
        private int number;

        public ReadDemo(IOrderRepository repo)
        {
            number = repo.Number;
            _orderRepository = repo;
        }

        public void Initialise(int Id)
        {
            var result = _orderRepository.AllQuerable().Where(x => x.OrderId == Id);

            Console.WriteLine(string.Format("ReadReadDemo: Found {0} for OrderId == {1}", result.Count(), Id));

        }

        public int Number { get { return number; } }
    }
}
