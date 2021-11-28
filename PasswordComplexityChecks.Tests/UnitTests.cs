using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PasswordComplexityChecks.Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Check_ShouldReturnTrue_WhenPasswordCorrect()
        {
            // Arrange
            var passwordChecker = new PasswordChecker();
            var password = "ASDqwe123$";

            // Act
            var result = passwordChecker.Check(password);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Check_ShouldReturnFalse_WhenPasswordShorterThen8()
        {
            // Arrange
            var passwordChecker = new PasswordChecker();
            var password = "Aq1$";

            // Act
            var result = passwordChecker.Check(password);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Check_ShouldReturnTrue_WhenPasswordCorrectLength()
        {
            // Arrange
            var passwordChecker = new PasswordChecker();
            var password = "ASqw12$$";

            // Act
            var result = passwordChecker.Check(password);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Check_ShouldReturnFalse_WhenPasswordLongerThen20()
        {
            // Arrange
            var passwordChecker = new PasswordChecker();
            var password = "ASDqwe123$ASDqwe123$ASDqwe123$";

            // Act
            var result = passwordChecker.Check(password);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Check_ShouldReturnTrue_WhenPasswordContainsDigits()
        {
            // Arrange
            var passwordChecker = new PasswordChecker();
            var password = "ASDqwe1$";

            // Act
            var result = passwordChecker.Check(password);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Check_ShouldReturnFalse_WhenPasswordDoesNotContainsDigits()
        {
            // Arrange
            var passwordChecker = new PasswordChecker();
            var password = "ASDqweASD$";

            // Act
            var result = passwordChecker.Check(password);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Check_ShouldReturnTrue_WhenPasswordContainsSpecialCharacters()
        {
            // Arrange
            var passwordChecker = new PasswordChecker();
            var password = "Aqwe123$";

            // Act
            var result = passwordChecker.Check(password);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Check_ShouldReturnFalse_WhenPasswordDoesNotContainsSpecialCharacters()
        {
            // Arrange
            var passwordChecker = new PasswordChecker();
            var password = "ASDqwe123";

            // Act
            var result = passwordChecker.Check(password);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Check_ShouldReturnTrue_WhenPasswordContainsUpperCase()
        {
            // Arrange
            var passwordChecker = new PasswordChecker();
            var password = "Aqwe123$";

            // Act
            var result = passwordChecker.Check(password);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Check_ShouldReturnFalse_WhenPasswordDoesNotContainsUpperCase()
        {
            // Arrange
            var passwordChecker = new PasswordChecker();
            var password = "asdqwe123$";

            // Act
            var result = passwordChecker.Check(password);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Check_ShouldReturnTrue_WhenPasswordContainsLowerCase()
        {
            // Arrange
            var passwordChecker = new PasswordChecker();
            var password = "ASDq123$";

            // Act
            var result = passwordChecker.Check(password);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Check_ShouldReturnFalse_WhenPasswordDoesNotContainsLowerCase()
        {
            // Arrange
            var passwordChecker = new PasswordChecker();
            var password = "ASDQWE123$";

            // Act
            var result = passwordChecker.Check(password);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
