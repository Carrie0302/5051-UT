﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;
using System.Collections.Generic;

namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelTests
    {
        [TestMethod]
        public void ReportViewModel_Instantiate_Default_Should_Pass()
        {

            //Arrange

            //Action
            var result = new ReportViewModel();

            //Assert
            Assert.IsNotNull(result);

        }


        [TestMethod]
        public void ReportViewModel_Get_Default_Should_Pass()
        {
            //Arrange
            var myTest = new ReportViewModel();

            //Action
            var result = myTest.LogViewModel;

            //Assert
            Assert.IsNotNull(result);
        }

    }
}
