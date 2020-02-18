using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieveSecureLoginsCore.Models
{
    /// <summary>
    /// Returns the secure login credentials
    /// </summary>
    public class LoginCredentials
    {
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
