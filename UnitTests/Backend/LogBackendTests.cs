using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Backend;
using HW1c.Models;
using System.Linq;

namespace UnitTests.Backend
{
    [TestClass]
    public class LogBackendTests
    {

        [TestMethod]
        public void LogBackend_Default_Index_Should_Pass()
        {
            //Arrange
            var myTest = LogBackend.Instance;

            // Act
            var result = myTest.Index();

            // Assert
            myTest.Reset();
            Assert.AreEqual(0, result.LogList.Count);
        }


    }
}
