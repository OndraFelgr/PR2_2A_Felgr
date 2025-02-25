using Microsoft.VisualStudio.TestTools.UnitTesting;
using dd.Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dd.Program.Tests
{
    [TestClass()]
    public class ToolsTests
    {
        [TestMethod()]
        public void FindMinTest()
        {
            int[] nums = [1,2,-4,18]
            Assert.AreEqual(-4, Tools.FindMin(nums)
        }
    }
}