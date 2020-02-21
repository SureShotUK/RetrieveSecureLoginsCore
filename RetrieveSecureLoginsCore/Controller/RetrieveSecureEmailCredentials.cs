using Microsoft.Extensions.Configuration;
using RetrieveSecureLoginsCore.Models;
using System;

namespace RetrieveSecureLoginsCore.Controller
{
    public class RetrieveSecureEmailCredentials : IRetrieveSecureEmailCredentials
    {
        /// <summary>
        /// Returns the secure login details for Email
        /// </summary>
        public  EmailCredentials EmailCredentials{ get; set; }
        public RetrieveSecureEmailCredentials()
        {
            var configs = GetConfiguration.GetConfigs;
            EmailCredentials = configs.Configuration.GetSection("EmailCredentials")
                .Get<EmailCredentials>();
        }
        public bool CheckAllPropertiesAreValid()
        {
            return (!String.IsNullOrWhiteSpace(EmailCredentials.UserName) &&
                !String.IsNullOrWhiteSpace(EmailCredentials.Password));
        }
    }
}
