using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;

namespace WorkerConfigNotFoundMRE
{
    #region Usings

    #endregion

    public class Functions
    {
        [FunctionName("Test")]
        public Task TriggerTest([TimerTrigger("%TestCron%")] TimerInfo timerInfo)
        {
            return Task.CompletedTask;
        }
    }
}
