using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Frist_Project_Stefanini.Api.Helper
{
    public class ConnectionString
    {
        public static IConfigurationRoot configurationRoot;

        public static string GetConnectionString()
        {
            configurationRoot = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile(@".\appsettings.json").Build();
            return configurationRoot.GetConnectionString("DefaultConnection");
        }
    }
}
