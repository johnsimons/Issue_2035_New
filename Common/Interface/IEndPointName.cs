namespace Common.Interface
{
    public interface IEndPointName
    {
        IConfigProvider ConfigProvider { get; set; }
        string AssemblyStartPattern { get; set; }
        string Retrieve();
    }
}
