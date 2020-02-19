using Microsoft.Extensions.Configuration;
using RetrieveSecureLoginsCore.Controller;
using RetrieveSecureLoginsCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieveSecureLoginsCore.Controller
{
    public class RetrieveSecureDatabaseCredentials : IRetrieveSecureDatabaseCredentials
    {
        public DatabaseCredentials DatabaseCredentials { get; set; }

        public RetrieveSecureDatabaseCredentials()
        {
            var configs = GetConfiguration.GetConfigs;
            DatabaseCredentials = configs.Configuration.GetSection("DatabaseCredentials")
                .Get<DatabaseCredentials>();
        }
        public bool CheckAllPropertiesAreValid()
        {
            return (!String.IsNullOrWhiteSpace(DatabaseCredentials.UserName) &&
                !String.IsNullOrWhiteSpace(DatabaseCredentials.Password) &&
                !String.IsNullOrWhiteSpace(DatabaseCredentials.NonLocalHost) &&
                !String.IsNullOrWhiteSpace(DatabaseCredentials.NonLocalPortNumber) &&
                !String.IsNullOrWhiteSpace(DatabaseCredentials.LocalHost) &&
                !String.IsNullOrWhiteSpace(DatabaseCredentials.LocalPortNumber) &&
                !String.IsNullOrWhiteSpace(DatabaseCredentials.SiteGroundDBName) &&
                !String.IsNullOrWhiteSpace(DatabaseCredentials.SiteGroundHost) &&
                !String.IsNullOrWhiteSpace(DatabaseCredentials.SiteGroundPortNumber) &&
                !String.IsNullOrWhiteSpace(DatabaseCredentials.SiteGroundPassword) &&
                !String.IsNullOrWhiteSpace(DatabaseCredentials.SiteGroundUserName)
                );
        }

    }
}
