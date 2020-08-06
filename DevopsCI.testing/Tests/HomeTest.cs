using DevopsCI.Client.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace DevopsCI.testing.Tests
{
    public class HomeTest
    {
        [Fact]
        public void HomeController_Test()
        {
            var sut = new HomeController();
            IActionResult view = sut.Index();

            Assert.NotNull(view);

        }
    }
}