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
    public class ErrorHandlingTests
    {
        private readonly Mock<IUserService> _mockUserService;
        private readonly Mock<ILogger<AccountController>> _mockLogger;
        private readonly AccountController _controller;

        public ErrorHandlingTests()
        {
            _mockUserService = new Mock<IUserService>();
            _mockLogger = new Mock<ILogger<AccountController>>();
            _controller = new AccountController(_mockUserService.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task Register_Should_Log_Error_When_Registration_Fails()
        {
            // Arrange
            var model = new AccountViewModel
            {
                Username = "testuser",
                Password = "testpassword"
            };

            // Simulate an error
            _mockUserService.Setup(service => service.Register(model.Username, model.Password)).ThrowsAsync(new Exception("Database error"));

            // Act
            var result = await _controller.Register(model);

            // Assert
            _mockLogger.Verify(logger => logger.LogError(It.IsAny<string>()));
            Assert.IsType<ViewResult>(result); // Ensure we are not redirecting, meaning the error was handled and the view was returned
        }

        [Fact]
        public async Task Login_Should_Log_Error_When_Authentication_Fails()
        {
            // Arrange
            var model = new AccountViewModel
            {
                Username = "testuser",
                Password = "testpassword"
            };

            // Simulate an error
            _mockUserService.Setup(service => service.Authenticate(model.Username, model.Password)).ThrowsAsync(new Exception("Authentication failed"));

            // Act
            var result = await _controller.Login(model);

            // Assert
            _mockLogger.Verify(logger => logger.LogError(It.IsAny<string>()));
            Assert.IsType<ViewResult>(result); // Ensure we are not redirecting, meaning the error was handled and the view was returned
        }
    }
}
