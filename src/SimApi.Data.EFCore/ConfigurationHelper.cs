using Microsoft.Extensions.Configuration;
using System.IO;

namespace SimApi.Data.EFCore
{
    /// <summary>
    /// Internal configuration helper, used to read the appsettings.json during EF core migrations
    /// </summary>
    internal static class ConfigurationHelper
    {
        private readonly static IConfigurationRoot _config;

        static ConfigurationHelper()
        {
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            _config = configBuilder.Build();
        }

        public static string GetSetting(string setting)
        {
            return _config[setting];
        }
    }
}