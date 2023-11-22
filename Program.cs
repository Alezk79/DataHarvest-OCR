using DataHarvest;
using Microsoft.Extensions.Configuration;

namespace TextToDigitalCode
{
    internal static class Program
    {        [STAThread]
        static void Main()
        {            ApplicationConfiguration.Initialize();
            Application.Run(new HarvestDesigner());

            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfiguration config = builder.Build();
        }


    }
}