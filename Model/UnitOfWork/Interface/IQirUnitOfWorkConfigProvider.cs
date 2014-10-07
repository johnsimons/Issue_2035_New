namespace Model.UnitOfWork.Interface
{
    public interface IQirUnitOfWorkConfigProvider
    {
        string DbConnectionString { get; }
        bool EFTracing { get; }
    }
}
