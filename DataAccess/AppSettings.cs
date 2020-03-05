using Microsoft.Extensions.Configuration;
using System.IO;

namespace Thenewwebapi.DataAccess
{
    public class AppSettings
    {
        private static IConfigurationRoot configuration;

        static AppSettings()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            configuration = builder.Build();
        }

        public static string ConnectionString
        {
            get { return configuration.GetConnectionString("ADONETConnectedLayerDEMO"); }
        }
    }
}