using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day9Assignment1.Models;

namespace MVCNlog.Tests
{
    public class DataEncryptionTests
    {
        [Fact]
        public void HashPassword_Should_Return_Hashed_Password()
        {
            // Arrange
            var password = "testpassword";

            // Act
            var hashedPassword = User.HashPassword(password);

            // Assert
            Assert.NotEqual(password, hashedPassword); // The hashed password should not be the same as the original password
        }

        [Fact]
        public void VerifyPassword_Should_Return_True_For_Valid_Password()
        {
            // Arrange
            var password = "testpassword";
            var hashedPassword = User.HashPassword(password);

            // Act
            var isValid = User.VerifyPassword(password, hashedPassword);

            // Assert
            Assert.True(isValid); // The password should be valid when compared to the hashed password
        }

        [Fact]
        public void VerifyPassword_Should_Return_False_For_Invalid_Password()
        {
            // Arrange
            var password = "testpassword";
            var wrongPassword = "wrongpassword";
            var hashedPassword = User.HashPassword(password);

            // Act
            var isValid = User.VerifyPassword(wrongPassword, hashedPassword);

            // Assert
            Assert.False(isValid); // The password should be invalid when compared to a wrong password
        }
    }
}
