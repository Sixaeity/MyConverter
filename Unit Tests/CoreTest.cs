using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyConverter.ConsoleApp;

namespace MyConverter.UnitTesting
{
    [TestClass]
    public class CoreTest
    {
        [TestMethod]
        public void TestInputProcessingReturnsTrue()
        {
            string[] commands = new string[] {"list", "ls", "unknown command"};
            foreach (string command in commands)
            {
                Core core = new Core();
                bool result = core.InputProcessing(command);
                Assert.IsTrue(result, $"Expected for \"{command}\": true; Actual: {result}");
            }
        }

        [TestMethod]    
        public void TestInputProcessingReturnsFalse()
        {
            string[] commands = new string[] {"quit", "q"};
            foreach (string command in commands)
            {
                Core core = new Core();
                bool result = core.InputProcessing(command);
                Assert.IsFalse(result, $"Expected for \"{command}\": false; Actual: {result}");
            }
        }
    }
}