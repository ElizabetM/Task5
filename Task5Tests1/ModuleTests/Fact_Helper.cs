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
    public class Fact_Helper
    {
        [TestMethod()]
        public void Fact_Test1()
        {
            var helper = new FuncCalculateHelper();
            double x = 1;

            Assert.IsTrue(helper.Fact(x) == (1));
        }

        [TestMethod()]
        public void Fact_Test2()
        {
            var helper = new FuncCalculateHelper();
            double x = 0;

            Assert.IsTrue(helper.Fact(x) == (1));
        }

        [TestMethod()]
        public void Fact_Test3()
        {
            var helper = new FuncCalculateHelper();
            double x = -1;

            Assert.IsFalse(helper.Fact(x) == double.NaN);
        }

        [TestMethod()]
        public void Fact_Test4()
        {
            var helper = new FuncCalculateHelper();
            double x = -12356;

            Assert.IsFalse(helper.Fact(x) == double.NaN);
        }

        [TestMethod()]
        public void Fact_Test5()
        {
            var helper = new FuncCalculateHelper();
            double x = double.MinValue;

            Assert.IsFalse(helper.Fact(x) == double.NaN);
        }

        [TestMethod()]
        public void Fact_Test6()
        {
            var helper = new FuncCalculateHelper();
            double x = double.NegativeInfinity;

            Assert.IsFalse(helper.Fact(x) == double.NaN);
        }

        [TestMethod()]
        public void Fact_Test7()
        {
            var helper = new FuncCalculateHelper();
            double x = double.PositiveInfinity;

            Assert.IsFalse(helper.Fact(x) == double.NaN);
        }

        [TestMethod()]
        public void Fact_Test8()
        {
            var helper = new FuncCalculateHelper();
            double x = 5;

            Assert.IsTrue(helper.Fact(x) == (5 * 4 * 3 * 2 * 1));
        }

        [TestMethod()]
        public void Fact_Test9()
        {
            var helper = new FuncCalculateHelper();
            double x = 10;

            Assert.IsTrue(helper.Fact(x) == (10 * 9 * 8 * 7 * 6 * 5 * 4 * 3 * 2 * 1));
        }

        [TestMethod()]
        public void Fact_Test10()
        {
            var helper = new FuncCalculateHelper();
            double x = 2.1;

            Assert.IsTrue(helper.Fact(x) == (2 * 1));
        }
    }
}