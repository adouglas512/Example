using DataAccessLibrary;
using ExampleWPF.Helpers;
using ExampleWPF.ViewModels;
using ExampleWPF.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows;

namespace ExampleWPF; 


public partial class App : Application {
    protected override void OnStartup(StartupEventArgs e) {
        var configBuilder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        var builder = new HostBuilder()
            .ConfigureAppConfiguration((config) => {
                config.Sources.Clear();
                config.AddConfiguration(configBuilder.Build());
            })
            .ConfigureServices((_, services) => {
                services
                    .AddSingleton<IDataAccess, DataAccess>()
                    .AddTransient<MainWindow>()
                    .AddTransient<UserControlViewModel>();

                services.AddFactory<DialogView>();
            });

        var host = builder.Build();
        using var scope = host.Services.CreateScope();
        var services = scope.ServiceProvider;

        var frm = services.GetRequiredService<MainWindow>();
        frm.Show();
    }
}
