
namespace RetrieveSecureLoginsCore
{
    public interface IRetrieveSecureCredentials <T> where T : class
    {
        bool CheckAllPropertiesAreValid();
    }
}
