using McDLabelEditor.WPF.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDLabelEditor.WPF.Infrastructure.Registrators;

internal static class ServiceRegistrator
{
    public static IServiceCollection AddServices(this IServiceCollection services) => services
        .AddSingleton<ViewNavigationService>()
        .AddSingleton<FileDialogService>();
}
