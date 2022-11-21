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
    public class DivideBy100_Helper
    {
        private const double CONST_BY_DIVISION = 100.0;

        [TestMethod()]
        public void DevisionBy100MaxDouble_Test1()
        {
            var helper = new FuncCalculateHelper();
            double x = double.MaxValue;

            Assert.IsTrue(helper.DevisionTo100(x) == (double.MaxValue / CONST_BY_DIVISION));
        }

        [TestMethod()]
        public void DevisionBy100MinDouble_Test2()
        {
            var helper = new FuncCalculateHelper();
            double x = double.MinValue;

            Assert.IsTrue(helper.DevisionTo100(x) == (double.MinValue / CONST_BY_DIVISION));
        }

        [TestMethod()]
        public void DevisionBy100Zero_Test3()
        {
            var helper = new FuncCalculateHelper();
            double x = 0.0;

            Assert.IsTrue(helper.DevisionTo100(x) == (0.0 / CONST_BY_DIVISION));
        }

        [TestMethod()]
        public void DevisionTo100Random1_Test4()
        {
            var helper = new FuncCalculateHelper();
            double x = 12345.645312;

            Assert.IsTrue(helper.DevisionTo100(x) == (12345.645312 / CONST_BY_DIVISION));
        }

        [TestMethod()]
        public void DevisionTo100Random2_Test5()
        {
            var helper = new FuncCalculateHelper();
            double x = 1_000_000.000_000_1;

            Assert.IsTrue(helper.DevisionTo100(x) == (1_000_000.000_000_1 / CONST_BY_DIVISION));
        }

        [TestMethod()]
        public void DevisionTo100Random3_Test6()
        {
            var helper = new FuncCalculateHelper();
            double x = -1.0;

            Assert.IsTrue(helper.DevisionTo100(x) == (-1.0 / CONST_BY_DIVISION));
        }

        [TestMethod()]
        public void DevisionTo100Random4_Test7()
        {
            var helper = new FuncCalculateHelper();
            double x = -12345.12345;

            Assert.IsTrue(helper.DevisionTo100(x) == (-12345.12345 / CONST_BY_DIVISION));
        }

        [TestMethod()]
        public void DevisionTo100NegativeInf_Test8()
        {
            var helper = new FuncCalculateHelper();
            double x = double.NegativeInfinity;

            Assert.IsFalse(helper.DevisionTo100(x) == double.NaN);
        }

        [TestMethod()]
        public void DevisionTo100PositiveInf_Test9()
        {
            var helper = new FuncCalculateHelper();
            double x = double.PositiveInfinity;

            Assert.IsFalse(helper.DevisionTo100(x) == double.NaN);
        }

        [TestMethod()]
        public void DevisionTo100NaN_Test10()
        {
            var helper = new FuncCalculateHelper();
            double x = double.NaN;

            Assert.IsFalse(helper.DevisionTo100(x) == double.NaN);
        }
    }
}
