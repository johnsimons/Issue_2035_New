
using Model.UnitOfWork.Interface;
namespace Common.Interface
{
    public interface IConfigProvider : IQirUnitOfWorkConfigProvider
    {
        string EnvironmentString { get; }
    }
}
