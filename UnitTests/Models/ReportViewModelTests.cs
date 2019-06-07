using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;

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
    }
}
