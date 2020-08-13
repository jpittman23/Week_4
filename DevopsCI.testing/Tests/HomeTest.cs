using DevopsCI.Client.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xunit;

namespace DevopsCI.testing.Tests
{
    public class HomeTest
    {
        private ILogger<HomeController> _logger = LoggerFactory.Create(options => options.AddConsole()).CreateLogger<HomeController>();
        [Fact]
        public void HomeController_Test()
        {
            var sut = new HomeController(_logger);
            IActionResult view = sut.Index();

            Assert.NotNull(view);

        }
    }
}