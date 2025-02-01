using Quartz;

namespace Presentation.Jobs;

[DisallowConcurrentExecution]//hamzaman ejra nashavad   
public class Print : IJob
{
    public async Task Execute(IJobExecutionContext context)
    {
        Console.WriteLine("hello");
    }
}
