using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionTest
{
    public static class SaySomthinFunction
    {
        [FunctionName("SaySomthinFunction")]
        public static void Run([QueueTrigger("myqueue-items", Connection = "ConnectionStrings:QueueStorage")] string myQueueItem,
          [Queue("myqueue-items-destination", Connection = "ConnectionStrings:QueueStorage")] out string myQueueItemCopy,
           ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
            myQueueItemCopy = myQueueItem;
        }
    }
}
