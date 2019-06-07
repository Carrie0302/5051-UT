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


        [TestMethod]
        public void LogBackend_Create_Valid_Item_Should_Pass()
        {
            // Arrange
            var myData = LogBackend.Instance;
            var item = new LogModel();
            item.ID = "IDCat";
            item.PhoneID = "PhoneCat";
            item.RecordedDateTime = DateTime.Parse("01/29/2019");
            item.Value = "ValueCat";

            // Action 
            var newItem = myData.Create(item);

            // Assert
            myData.Reset();
            Assert.AreEqual(item.ID, newItem.ID);
            Assert.AreEqual(item.PhoneID, newItem.PhoneID);
            Assert.AreEqual(item.RecordedDateTime, newItem.RecordedDateTime);
            Assert.AreEqual(item.Value, newItem.Value);

        }
    }
}
