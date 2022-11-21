using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Tests
{
    [TestClass()]
    public class FuncCalculateHelperTests
    {
        [TestMethod()]
        public void FactTest()
        {
            var helper = new FuncCalculateHelper();
            double x = 100;
            double res = helper.Fact(x);
            Assert.IsTrue(helper.CalculateY(x) == res);
        }
    }
}