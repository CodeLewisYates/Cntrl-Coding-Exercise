using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace AzureFunction
{
    public class AzureFunction
    {
        private readonly IEmailService emailService;

        public AzureFunction(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        [FunctionName("AzureFunction")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            ObjectResult result;
            string responseMessage;

            string body = await new StreamReader(req.Body).ReadToEndAsync();
            Email email = JsonConvert.DeserializeObject<Email>(body);

            EmailVerification verifiedEmail = emailService.IsValidEmail(email);
            if (!verifiedEmail.IsValid)
            {
                responseMessage = verifiedEmail.ResponseMessage;
                result = new BadRequestObjectResult(responseMessage);
            }
            else
            {
                responseMessage = emailService.SendEmail(email);
                result = new OkObjectResult(responseMessage);
            }

            return result;
        }
    }
}
