using System;
using BAL;
using Common;
using Common.Interface;
using NServiceBus.Pipeline;
using NServiceBus.Pipeline.Contexts;
using NServiceBus.Unicast.Behaviors;
using Schroders.Crpt.Qir.Model.Repository;
using NServiceBus;

namespace NserviceBusMultiThreading
{
	public class EndpointConfig : IConfigureThisEndpoint, AsA_Server
    {

    }

    public class SetupContainer : INeedInitialization
    {
        public void Init()
        {
            Configure.Component<EntityFrameworkUnitOfWork>(DependencyLifecycle.InstancePerUnitOfWork);
            Configure.Component<NServiceBusClassBuilder>(DependencyLifecycle.InstancePerUnitOfWork);
            Configure.Component<ConfigProvider>(DependencyLifecycle.InstancePerUnitOfWork);
            Configure.Component<OrderRepository>(DependencyLifecycle.InstancePerUnitOfWork);
            Configure.Component<OrdersQryRepository>(DependencyLifecycle.InstancePerUnitOfWork);
            Configure.Component<ReadDemo>(DependencyLifecycle.InstancePerCall);
            Configure.Component<WriteDemo>(DependencyLifecycle.InstancePerCall);
        }
    }

    class CaptureChildBuilderBehavior : IBehavior<HandlerInvocationContext>
    {
        public IClassBuilder Builder { get; set; }

        public void Invoke(HandlerInvocationContext context, Action next)
        {
            Builder.SetBuilder(context.Builder);
            next();
        }

        private class CaptureChildBuilderBehaviorOverride : PipelineOverride
        {
            public override void Override(BehaviorList<HandlerInvocationContext> behaviorList)
            {
                behaviorList.InsertBefore<InvokeHandlersBehavior, CaptureChildBuilderBehavior>();
            }
        }
    }
}
