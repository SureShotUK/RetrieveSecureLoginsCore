using Microsoft.Extensions.Configuration;
using RetrieveSecureLoginsCore.Models;
using System;

namespace RetrieveSecureLoginsCore.Controller
{
    public class RetrieveSecureAppCredentials : IRetrieveSecureAppCredentials
    {
        public AppCredentials AppCredentials { get; set; }

        public RetrieveSecureAppCredentials()
        {
            var configs = GetConfiguration.GetConfigs;
            AppCredentials = configs.Configuration.GetSection("AppCredentials")
                .Get<AppCredentials>();
        }
        public bool CheckAllPropertiesAreValid()
        {
            return (!String.IsNullOrWhiteSpace(AppCredentials.ClientId) &&
                !String.IsNullOrWhiteSpace(AppCredentials.TenantId) &&
                !String.IsNullOrWhiteSpace(AppCredentials.ClientSecret) &&
                !String.IsNullOrWhiteSpace(AppCredentials.AzureCloudInstance) &&
                !String.IsNullOrWhiteSpace(AppCredentials.AadAuthorityAudience) &&
                !String.IsNullOrWhiteSpace(AppCredentials.MicrosoftGraphBaseEndpoint)
                );
        }
    }
}
