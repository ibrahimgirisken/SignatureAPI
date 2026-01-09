using Microsoft.Extensions.Configuration;

namespace SignatureAPI.Persistence
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                var configurationBuilder = new ConfigurationBuilder();
                try
                {
                    configurationBuilder.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../SignatureAPI/SignatureAPI.API"));
                    configurationBuilder.AddJsonFile("appsettings.json");
                }
                catch (Exception)
                {
                    throw;
                }
                IConfigurationRoot configuration = configurationBuilder.Build();
                return configuration.GetConnectionString("MySql");
            }
        }
    }
}
