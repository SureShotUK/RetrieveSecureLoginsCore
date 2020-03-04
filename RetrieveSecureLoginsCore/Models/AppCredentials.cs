namespace RetrieveSecureLoginsCore.Models
{
    /// <summary>
    /// Returns the credentials object for the App
    /// </summary>
    public class AppCredentials
    {
        public string ClientId { get; set; }
        public string TenantId { get; set; }
        public string ClientSecret { get; set; }
        public string AzureCloudInstance { get; set; }
        public string AadAuthorityAudience { get; set; }
        public string MicrosoftGraphBaseEndpoint { get; set; }
    }
}
