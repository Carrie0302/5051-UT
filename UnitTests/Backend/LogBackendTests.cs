﻿using System;
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

        [TestMethod]
        public void LogBackend_Read_Item_Should_Pass()
        {
            // Arrange
            var myData = LogBackend.Instance;
            var item = new LogModel();
            item.ID = "IDDog";
            item.PhoneID = "PhoneDog";
            item.RecordedDateTime = DateTime.Parse("03/01/2018");
            item.Value = "ValueDog";
            myData.Create(item);

            //Action
            var result = myData.Read(item.ID);

            //Assert
            myData.Reset();
            Assert.AreEqual(item.ID, result.ID);
            Assert.AreEqual(item.Value, result.Value);
            Assert.AreEqual(item.PhoneID, result.PhoneID);
            Assert.AreEqual(item.RecordedDateTime, result.RecordedDateTime);
            Assert.AreEqual(item.AppVersion, result.AppVersion);

        }

        [TestMethod]
        public void LogBackend_Update_Item_Should_Pass()
        {
            // Arrange
            var myData = LogBackend.Instance;
            var item = new LogModel();
            item.ID = "IDDog";
            item.PhoneID = "PhoneDog";
            item.RecordedDateTime = DateTime.Parse("03/01/2018");
            item.Value = "ValueDog";
            myData.Create(item);

            // Get the first item from the list
            var oldItem = myData.Index().LogList[0];

            // Change the ID
            var newPhoneID = "UpdatedPhoneP";
            oldItem.PhoneID = newPhoneID;

            // Act
            var result = myData.Update(oldItem);
            var newItem = myData.Read(oldItem.ID);

            // Assert
            myData.Reset();
            Assert.AreEqual(newPhoneID, newItem.PhoneID);
        }

        [TestMethod]
        public void LogBackend_Delete_Only_Item_Should_Pass()
        {
            // Arrange
            var myData = LogBackend.Instance;
            var item = new LogModel();
            item.ID = "IDDog";
            item.PhoneID = "PhoneDog";
            item.RecordedDateTime = DateTime.Parse("03/01/2018");
            item.Value = "ValueDog";
            myData.Create(item);

            var item2 = new LogModel();
            item2.ID = "IDCat";
            item2.PhoneID = "PhoneCat";
            item2.RecordedDateTime = DateTime.Parse("04/11/2018");
            item2.Value = "ValueCat";
            myData.Create(item2);

            // Act
            var result = myData.Delete(item.ID);
            var newItem = myData.Index().LogList[0];

            // Assert
            myData.Reset();
            Assert.AreNotEqual(item.PhoneID, newItem.PhoneID);
        }



    }
}
