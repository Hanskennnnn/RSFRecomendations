using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace RSFRecomendations
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var services = new ServiceCollection();
            services.AddDbContext<MyDBContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            var serviceProvider = services.BuildServiceProvider();

            var config = new NLog.Config.LoggingConfiguration();

            var logfile = new NLog.Targets.FileTarget("logfile")
            {
                FileName = "log.txt"
            };

            config.AddRule(NLog.LogLevel.Trace, NLog.LogLevel.Fatal, logfile);

            NLog.LogManager.Configuration = config;

            var logger = NLog.LogManager.GetCurrentClassLogger();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);


            Application.Run(new LoginForm());

        }
    }
}