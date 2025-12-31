using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
