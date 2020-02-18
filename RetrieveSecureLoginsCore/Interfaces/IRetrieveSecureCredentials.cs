using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieveSecureLoginsCore
{
    public interface IRetrieveSecureCredentials <T> where T : class
    {
        bool CheckAllPropertiesAreValid();
    }
}
