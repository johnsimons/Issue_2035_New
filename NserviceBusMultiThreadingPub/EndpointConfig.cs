using Common;
using Model.UnitOfWork;
using Schroders.Crpt.Qir.Model.Repository;

namespace NserviceBusMultiThreadingPub
{
    using NServiceBus;

    public class EndpointConfig : IConfigureThisEndpoint, IWantCustomLogging, AsA_Publisher
    {
        public void Init()
        {
            Configure.With() .DefaultBuilder();
        }
    }

    public class SetupContainer : INeedInitialization
    {
        public void Init()
        {
            Configure.Component<ConfigProvider>(DependencyLifecycle.InstancePerUnitOfWork);
            Configure.Component<QirUnitOfWork>(DependencyLifecycle.InstancePerUnitOfWork);
            Configure.Component<OrderRepository>(DependencyLifecycle.InstancePerUnitOfWork);
        }
    }
}
