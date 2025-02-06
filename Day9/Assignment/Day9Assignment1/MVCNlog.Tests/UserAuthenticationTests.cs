using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day9Assignment1.Controllers;
using Day9Assignment1.Services;
using Day9Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using Microsoft.Extensions.Logging;

namespace MVCNlog.Tests
{
    public class UserAuthenticationTests
    {
        private readonly Mock<IUserService> _mockUserService;
        private readonly Mock<ILogger<AccountController>> _mockLogger;
        private readonly AccountController _controller;

        public UserAuthenticationTests()
        {
            // Mock the IUserService and ILogger<AccountController>
            _mockUserService = new Mock<IUserService>();
            _mockLogger = new Mock<ILogger<AccountController>>();

            // Initialize the AccountController with the mocked dependencies
            _controller = new AccountController(_mockUserService.Object, _mockLogger.Object);
        }

        [Fact]
        public async Task Register_Should_Register_User_Successfully()
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
            Assert.IsType<RedirectToActionResult>(result);
        }

        [Fact]
        public async Task Login_Should_Authenticate_User_Successfully()
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
            Assert.IsType<RedirectToActionResult>(result);
        }
    }
}
