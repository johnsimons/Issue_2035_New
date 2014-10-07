using System;
using System.Linq;
using Schroders.Crpt.Qir.Model.Repository;

namespace BAL
{
    public interface IWriteDemo
    {
        IOrderRepository OrderRepository { get; set; }
        IOrdersQryRepository OrdersQryRepository { get; set; }
        void Initialise(int Id);
    }

    public class WriteDemo : IWriteDemo
    {
        public IOrderRepository OrderRepository { get; set; }
        public IOrdersQryRepository OrdersQryRepository { get; set; }

        public void Initialise(int Id)
        {
            try
            {
                var orders = OrderRepository.AllQuerable().Where(x => x.OrderId == Id);
                foreach (var order in orders)
                {
                    order.RequiredDate = DateTime.Now;
                }
                var orderQrys = OrdersQryRepository.AllQuerable().Where(x => x.OrderId == Id);
                foreach (var orderQry in orderQrys)
                {
                    orderQry.RequiredDate = DateTime.Now;
                }

                OrderRepository.SaveChanges();
                Console.WriteLine(string.Format("WiteDemo: Changed Order Date for {0}", Id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
