using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MoqProject;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DoesUserExist_Throws_WhenNoDbConnection()
        {
            // Arrange
            var mock = new Mock<IDataBase>();
            mock.Setup(o => o.ConnectToDataBase()).Returns(false);

            var dbAccessor = new DbAccessor(mock.Object);

            // Act
            bool exist = dbAccessor.DoesUserExist(1234);

            // Assert
            Assert.IsTrue(exist);
        }

        [TestMethod]
        public void DoesUserExist_ReturnTrue_WhenConnection()
        {
            // Arrange
            var mock = new Mock<IDataBase>();
            mock.Setup(o => o.ConnectToDataBase()).Returns(true);

            var dbAccessor = new DbAccessor(mock.Object);

            // Act
            bool exist = dbAccessor.DoesUserExist(1234);

            // Assert
            Assert.IsTrue(exist);
        }

        [TestMethod]
        public void DoesUserExist_IsFalse_WhenPlayerDontExist()
        {
            // Arrange
            var mock = new Mock<IDataBase>();


            // Act


            // Assert
        }
    }
}
