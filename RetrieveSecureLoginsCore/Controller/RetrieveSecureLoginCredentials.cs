using Microsoft.Extensions.Configuration;
using RetrieveSecureLoginsCore.Controller;
using RetrieveSecureLoginsCore.Models;
using System;

namespace RetrieveSecureLoginsCore
{
    public class RetrieveSecureLoginCredentials : IRetrieveSecureLoginCredentials
    {
        
        public LoginCredentials LoginCredentials { get; set; }
        /// <summary>
        /// Retrieves the secure credentials for the generic application login
        /// </summary>
        public RetrieveSecureLoginCredentials()
        {
            var configs = GetConfiguration.GetConfigs;

            LoginCredentials = configs.Configuration.GetSection("LoginCredentials")
                                .Get<LoginCredentials>();
        }
        public bool CheckAllPropertiesAreValid()
        {
            return (!String.IsNullOrWhiteSpace(LoginCredentials.UserName) && 
                !String.IsNullOrWhiteSpace(LoginCredentials.Password));
        }

    }
}
