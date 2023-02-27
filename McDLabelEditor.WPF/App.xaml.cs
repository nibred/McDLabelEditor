﻿using McDLabelEditor.WPF.Infrastructure.Registrators;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace McDLabelEditor.WPF
{
    public partial class App : Application
    {
        private static IHost _host;
        private static IHostBuilder CreateHostBuilder(string[] args) => Host
            .CreateDefaultBuilder(args)
            .ConfigureServices(ConfiguteServices);
        private static void ConfiguteServices(HostBuilderContext host, IServiceCollection services) => services
            .AddViewModels()
            .AddServices();
        public static IServiceProvider Services => MainHost.Services;
        public static IHost MainHost => _host ??= CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

        protected override async void OnStartup(StartupEventArgs e)
        {
            var host = MainHost;
            await host.StartAsync();
            base.OnStartup(e);
        }
        protected override async void OnExit(ExitEventArgs e)
        {
            using var host = MainHost;
            base.OnExit(e);
            await host.StopAsync();
        }
    }
}
