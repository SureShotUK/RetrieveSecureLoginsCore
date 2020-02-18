using RetrieveSecureLoginsCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieveSecureLoginsCore
{
    interface IRetrieveSecureEmailCredentials : IRetrieveSecureCredentials<EmailCredentials>
    {
    }
}
