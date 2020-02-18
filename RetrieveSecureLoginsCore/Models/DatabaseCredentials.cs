using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieveSecureLoginsCore.Models
{
    /// <summary>
    /// Returns the credentials object for the Database
    /// </summary>
    public class DatabaseCredentials
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string LocalPortNumber { get; set; }
        public string LocalHost { get; set; }
        public string NonLocalPortNumber { get; set; }
        public string NonLocalHost { get; set; }
    }
}
