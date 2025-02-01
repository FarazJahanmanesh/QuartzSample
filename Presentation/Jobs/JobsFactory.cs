using Quartz;
using Quartz.Spi;

namespace Presentation.Jobs;
public class JobsFactory : IJobFactory
{
    private readonly IServiceProvider _serviceProvider;
    public JobsFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    public IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
    {
        //moarefi service ha    
        return _serviceProvider.GetRequiredService(bundle.JobDetail.JobType) as IJob;
    }

    public void ReturnJob(IJob job)
    {
        
    }
}
