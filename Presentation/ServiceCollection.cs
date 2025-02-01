using Microsoft.Extensions.DependencyInjection;
using Presentation.Jobs;
using Quartz;
using Quartz.Impl;
using Quartz.Spi;

namespace Presentation;
public static class ServiceCollection
{
    public static IServiceCollection AddServices(this IServiceCollection services)
        => services.AddSingleton<IJobFactory, JobsFactory>()
        .AddSingleton<ISchedulerFactory, StdSchedulerFactory>()
        .AddSingleton<Print>()
        .AddSingleton(new JobsSchedule(typeof(Print),"0/5 * * * ?"));

}
