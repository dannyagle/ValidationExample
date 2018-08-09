using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ValidationExample.Engines;
using ValidationExample.Models;

namespace ValidationExample.Tests
{
    [TestClass]
    public class MegaProcessorTests
    {
        [TestMethod]
        public void Process_WhenIncomingIsValid_NoExceptions()
        {
            // setup
            var widgetEngine = new MegaProcessor();
            var model = new Incoming
            {
                Workflow = "Good",
                FirstName = "Joe",
                LastName = "Coolio",
                Nickname = "Joey",
                BirthDate = "01/31/1980"
            };

            // test
            try
            {
                widgetEngine.Process(model);
            }
            // assert
            catch (Exception ex)
            {
                Assert.Fail();
            }

        }

    }
}
