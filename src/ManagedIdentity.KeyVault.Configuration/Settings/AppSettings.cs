namespace ManagedIdentity.KeyVault.Configuration.Settings
{
    public class AppSettings
    {
        public HomePage HomePage { get; set; }
        public ExternalService ExternalService { get; set; }
    }

    public class HomePage
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class ExternalService
    {
        public string ClientId { get; set; }
        public string ApiKey { get; set; }
    }
}
