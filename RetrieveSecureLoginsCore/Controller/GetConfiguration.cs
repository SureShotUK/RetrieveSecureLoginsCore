using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieveSecureLoginsCore.Controller
{
    public sealed class GetConfiguration
    {
        private static GetConfiguration _instance = null;
        public static GetConfiguration GetConfigs
        {
            get
            {
                if (_instance == null) _instance = new GetConfiguration();
                return _instance;
            }
        }

        public IConfigurationRoot Configuration { get; set; }

        private GetConfiguration()
        {
            var devEnvironmentVariable = Environment.GetEnvironmentVariable("NETCORE_ENVIRONMENT");
            var isDevelopment = string.IsNullOrEmpty(devEnvironmentVariable) ||
                devEnvironmentVariable.ToLower() == "development";

            var builder = new ConfigurationBuilder();

            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            if (isDevelopment)
            {
                builder.AddUserSecrets<GetConfiguration>();
            }

            Configuration = builder.Build();
        }

    }
}
