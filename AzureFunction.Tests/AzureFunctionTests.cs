using Xunit;
using Moq;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AzureFunction.Tests
{
    public class AzureFunctionTests
    {
        private readonly ILogger logger = new Mock<ILogger>().Object;
        private readonly EmailService emailService = new();

        [Theory]
        [InlineData("example", "subject", "body")]
        public void ShouldBeInvalidEmail(string to, string subject, string body)
        {
            var result = emailService.IsValidEmail(new Email { To = to, Subject = subject, Body = body });

            Assert.False(result.IsValid);
        }

        [Theory]
        [InlineData("example@gmail.com", "subject", "body")]
        public void ShouldBeValidEmail(string to, string subject, string body)
        {
            var result = emailService.IsValidEmail(new Email { To = to, Subject = subject, Body = body });

            Assert.True(result.IsValid);
        }

        [Theory]
        [InlineData("example@gmail.com", "", "body")]
        public void ShouldBeInvalidSubject(string to, string subject, string body)
        {
            var result = emailService.IsValidEmail(new Email { To = to, Subject = subject, Body = body });

            Assert.Contains("provide an email subject", result.ResponseMessage);
        }

        [Theory]
        [InlineData("example@gmail.com","subject","body")]
        public async void ShouldReturnOKResult(string to, string subject, string body)
        {
            var httpClient = CreateMockRequest(new Email { To = to, Subject = subject, Body = body });
            var result = await new AzureFunction(emailService).Run(httpClient.Object, logger);

            Assert.IsType<OkObjectResult>(result);
        }

        [Theory]
        [InlineData("example@gmail.com", "subject", "")]
        public void ShouldBeInvalidBody(string to, string subject, string body)
        {
            var result = emailService.IsValidEmail(new Email { To = to, Subject = subject, Body = body });

            Assert.Contains("provide a body", result.ResponseMessage);
        }

        public static Mock<HttpRequest> CreateMockRequest(object body)
        {
            MemoryStream memoryStream = new();
            StreamWriter streamWriter = new(memoryStream);

            var json = JsonConvert.SerializeObject(body);
            streamWriter.Write(json);
            streamWriter.Flush();

            memoryStream.Position = 0;
            var mockRequest = new Mock<HttpRequest>();
            mockRequest.Setup(x => x.Body).Returns(memoryStream);

            return mockRequest;
        }
    }
}