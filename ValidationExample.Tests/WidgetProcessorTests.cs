using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ValidationExample.Engines;
using ValidationExample.Models;

namespace ValidationExample.Tests
{
    [TestClass]
    public class WidgetProcessorTests
    {
        [TestMethod]
        public void Process_WhenIncomingWorkflowIsNull_ThrowsException()
        {
            // setup
            var widgetEngine = new WidgetProcessor();
            var model = new Incoming();

            // test
            try
            {
                widgetEngine.Process(model);
            }
            // assert
            catch(Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("incoming.Workflow"));
            }

        }
    }
}
