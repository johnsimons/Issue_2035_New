using System;
using Common.Interface;
using NServiceBus.ObjectBuilder;

namespace Common
{
    public class NServiceBusClassBuilder : IClassBuilder
    {
        private IBuilder _builder;

        public T Build<T>()
        {
            return _builder.Build<T>();
        }

        public object Build(Type typeToBuild)
        {
            return _builder.Build(typeToBuild);
        }

        public object BuildAll(Type typeToBuild)
        {
            return _builder.BuildAll(typeToBuild);
        }

        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }
    }
}
