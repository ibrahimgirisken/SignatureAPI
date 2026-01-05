using Microsoft.Extensions.Configuration;

namespace SignatureAPI.Persistence
{
     static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                try
                {
                    configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/SignatureAPI.API"));
                    configurationManager.AddJsonFile("appsettings.json");
                }
                catch (Exception)
                {

                    throw;
                }
                return configurationManager.GetConnectionString("MySql");
            }
        }
    }
}
