namespace Presentation.Jobs;
public class JobsSchedule
{
    public Type JobType { get; set; }
    public string CronExperssion { get; set; }
    public JobsSchedule(Type jobType, string cronExperssion)
    {
        JobType = jobType;
        CronExperssion = cronExperssion;
    }
}
