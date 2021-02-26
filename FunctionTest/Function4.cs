using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionTest
{
    public static class Function4
    {
        [FunctionName("Function4")]
        public static void Run([QueueTrigger("QueueName", Connection = "ConnectionStrings:QueueStorage")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
