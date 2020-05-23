using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;



namespace FunctionExampleApp
{
    public static class SilniaFunction
    {
        [FunctionName("SilniaFunction")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            Silnia silnia = new Silnia();
            string param = req.Query["number"];
            int number = Convert.ToInt32(param);
        }
    }
}
