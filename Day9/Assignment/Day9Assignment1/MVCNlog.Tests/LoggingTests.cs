using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day9Assignment1.Controllers;
using Day9Assignment1.Models;
using Day9Assignment1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace MVCNlog.Tests
{
    public class LoggingTests
    {
        private readonly Mock<IUserService> _mockUserService;
        private readonly Mock<ILogger<AccountController>> _mockLogger;
        private readonly AccountController _controller;

        public LoggingTests()
        {
            _mockUserService = new Mock<IUserService>();
            _mockLogger = new Mock<ILogger<AccountController>>();
            _controller = new AccountController(_mockUserService.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task Register_Should_Log_Successfully_When_User_Registers()
        {
            // Arrange
            var model = new AccountViewModel
            {
                Username = "testuser",
                Password = "testpassword"
            };

            _mockUserService.Setup(service => service.Register(model.Username, model.Password)).ReturnsAsync(true);

            // Act
            var result = await _controller.Register(model);

            // Assert
            _mockLogger.Verify(logger => logger.LogInformation(It.Is<string>(s => s.Contains("registered successfully"))));
            Assert.IsType<RedirectToActionResult>(result); // Ensure that we are redirecting after successful registration
        }

        [Fact]
        public async Task Login_Should_Log_Successfully_When_User_Logs_In()
        {
            // Arrange
            var model = new AccountViewModel
            {
                Username = "testuser",
                Password = "testpassword"
            };

            _mockUserService.Setup(service => service.Authenticate(model.Username, model.Password)).ReturnsAsync(true);

            // Act
            var result = await _controller.Login(model);

            // Assert
            _mockLogger.Verify(logger => logger.LogInformation(It.Is<string>(s => s.Contains("logged in successfully"))));
            Assert.IsType<RedirectToActionResult>(result); // Ensure that we are redirecting after successful login
        }
    }
}
