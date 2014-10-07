

using System;
using NServiceBus.ObjectBuilder;

namespace Common.Interface
{
    public interface IClassBuilder
    {
        T Build<T>();
        object Build(Type typeToBuild);
        object BuildAll(Type typeToBuild);

        void SetBuilder(IBuilder builder);
    }
}
