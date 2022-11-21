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
    public class Exponenta_Helper
    {
        [TestMethod()]
        public void Exponenta_Test1()
        {
            var helper = new FuncCalculateHelper();
            double x = 1;

            Assert.IsTrue(helper.Exponenta(x) == Math.Pow(Math.E, x));
        }

        [TestMethod()]
        public void Exponenta_Test2()
        {
            var helper = new FuncCalculateHelper();
            double x = 0;

            Assert.IsTrue(helper.Exponenta(x) == Math.Pow(Math.E, x));
        }

        [TestMethod()]
        public void Exponenta_Test3()
        {
            var helper = new FuncCalculateHelper();
            double x = double.MaxValue;

            Assert.IsTrue(helper.Exponenta(x) == Math.Pow(Math.E, x));
        }

        [TestMethod()]
        public void Exponenta_Test4()
        {
            var helper = new FuncCalculateHelper();
            double x = double.MinValue;

            Assert.IsTrue(helper.Exponenta(x) == Math.Pow(Math.E, x));
        }

        [TestMethod()]
        public void Exponenta_Test5()
        {
            var helper = new FuncCalculateHelper();
            double x = -1;

            Assert.IsTrue(helper.Exponenta(x) == Math.Pow(Math.E, x));
        }

        [TestMethod()]
        public void Exponenta_Test6()
        {
            var helper = new FuncCalculateHelper();
            double x = 1234.1234;

            Assert.IsTrue(helper.Exponenta(x) == Math.Pow(Math.E, x));
        }

        [TestMethod()]
        public void Exponenta_Test7()
        {
            var helper = new FuncCalculateHelper();
            double x = -1234.1234;

            Assert.IsTrue(helper.Exponenta(x) == Math.Pow(Math.E, x));
        }

        [TestMethod()]
        public void Exponenta_Test8()
        {
            var helper = new FuncCalculateHelper();
            double x = double.NegativeInfinity;

            Assert.IsTrue(helper.Exponenta(x) == Math.Pow(Math.E, x));
        }

        [TestMethod()]
        public void Exponenta_Test9()
        {
            var helper = new FuncCalculateHelper();
            double x = double.PositiveInfinity;

            Assert.IsTrue(helper.Exponenta(x) == Math.Pow(Math.E, x));
        }

        [TestMethod()]
        public void Exponenta_Test10()
        {
            var helper = new FuncCalculateHelper();
            double x = 3120230320;

            Assert.IsTrue(helper.Exponenta(x) == Math.Pow(Math.E, x));
        }
    }
}
