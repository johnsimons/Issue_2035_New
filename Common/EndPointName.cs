using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interface;

namespace Common
{
    public class EndPointName : IEndPointName
    {
        public IConfigProvider ConfigProvider { get; set; }

        public string AssemblyStartPattern { get; set; }

        public EndPointName() { }

        public EndPointName(IConfigProvider configProvider, string assemblyStartPattern)
            : this(assemblyStartPattern)
        {
            ConfigProvider = configProvider;
        }

        public EndPointName(string assemblyStartPattern)
        {
            AssemblyStartPattern = assemblyStartPattern;
        }

        public string Retrieve()
        {
            var endPointName =
                System.Reflection.Assembly.GetCallingAssembly()
                    .ManifestModule.Name
                    .Replace(".dll", string.Empty);

            return !String.IsNullOrEmpty(ConfigProvider.EnvironmentString)
                ? AddEnvironmentToEndPoint(endPointName) : endPointName;
        }

        private string AddEnvironmentToEndPoint(string endPointName)
        {
            if (!String.IsNullOrEmpty(AssemblyStartPattern))
            {
                return endPointName.Replace(AssemblyStartPattern,
                    string.Format("{0}.{1}", AssemblyStartPattern, ConfigProvider.EnvironmentString));
            }

            return string.Format("{0}.{1}", ConfigProvider.EnvironmentString, endPointName);
        }
    }
}
