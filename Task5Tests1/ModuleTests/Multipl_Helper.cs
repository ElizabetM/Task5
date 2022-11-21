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
    public class Multipl_Helper
    {
        [TestMethod()]
        public void Multiple_Test1()
        {
            var helper = new FuncCalculateHelper();
            double x = 5;
            double x2 = 5;

            Assert.IsTrue(helper.Multiple(x, x2) == (x * x2));
        }

        [TestMethod()]
        public void Multiple_Test2()
        {
            var helper = new FuncCalculateHelper();
            double x = 1;
            double x2 = 1;

            Assert.IsTrue(helper.Multiple(x, x2) == (x * x2));
        }

        [TestMethod()]
        public void Multiple_Test3()
        {
            var helper = new FuncCalculateHelper();
            double x = 1;
            double x2 = 0;

            Assert.IsTrue(helper.Multiple(x, x2) == (x * x2));
        }

        [TestMethod()]
        public void Multiple_Test4()
        {
            var helper = new FuncCalculateHelper();
            double x = 12345.12345;
            double x2 = 321.543;

            Assert.IsTrue(helper.Multiple(x, x2) == (x * x2));
        }

        [TestMethod()]
        public void Multiple_Test5()
        {
            var helper = new FuncCalculateHelper();
            double x = -123;
            double x2 = 5534;

            Assert.IsTrue(helper.Multiple(x, x2) == (x * x2));
        }

        [TestMethod()]
        public void Multiple_Test6()
        {
            var helper = new FuncCalculateHelper();
            double x = 987634;
            double x2 = -1235;

            Assert.IsTrue(helper.Multiple(x, x2) == (x * x2));
        }

        [TestMethod()]
        public void Multiple_Test7()
        {
            var helper = new FuncCalculateHelper();
            double x = double.MaxValue;
            double x2 = double.MaxValue;

            Assert.IsTrue(helper.Multiple(x, x2) == (x * x2));
        }

        [TestMethod()]
        public void Multiple_Test8()
        {
            var helper = new FuncCalculateHelper();
            double x = double.MinValue;
            double x2 = double.MaxValue;

            Assert.IsTrue(helper.Multiple(x, x2) == (x * x2));
        }

        [TestMethod()]
        public void Multiple_Test9()
        {
            var helper = new FuncCalculateHelper();
            double x = double.NegativeInfinity;
            double x2 = 5;

            Assert.IsTrue(helper.Multiple(x, x2) == (x * x2));
        }

        [TestMethod()]
        public void Multiple_Test10()
        {
            var helper = new FuncCalculateHelper();
            double x = double.PositiveInfinity;
            double x2 = 5;

            Assert.IsTrue(helper.Multiple(x, x2) == (x * x2));
        }
    }
}
