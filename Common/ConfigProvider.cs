


using System;

namespace Common
{
    using System.Configuration;
    using Common.Interface;

    public class ConfigProvider : IConfigProvider
    {

        public string DbConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["QIRDbConnection"].ConnectionString; }
        }

        public bool EFTracing
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["EFTracing"]); }
        }


        public string EnvironmentString
        {
            get
            {
                return ConfigurationManager.AppSettings["environment"];
            }
        }
    }
}
