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
    public class Ln_Helper
    {
        [TestMethod()]
        public void Ln_Test1()
        {
            var helper = new FuncCalculateHelper();
            double x = 1;

            var ln = helper.Ln(x);

            Assert.IsTrue(Math.Pow(Math.E, ln) == x);
        }

        [TestMethod()]
        public void Ln_Test2()
        {
            var helper = new FuncCalculateHelper();
            double x = 0;

            var ln = helper.Ln(x);

            Assert.IsTrue(Math.Pow(Math.E, ln) == x);
        }

        [TestMethod()]
        public void Ln_Test3()
        {
            var helper = new FuncCalculateHelper();
            double x = 1234.1234;

            var ln = helper.Ln(x);

            Assert.IsTrue(Math.Pow(Math.E, ln) == x);
        }

        [TestMethod()]
        public void Ln_Test4()
        {
            var helper = new FuncCalculateHelper();
            double x = 1_000_000_000_000;

            var ln = helper.Ln(x);

            Assert.IsTrue(Math.Round(Math.Pow(Math.E, ln), MidpointRounding.ToEven) == x);
        }

        [TestMethod()]
        public void Ln_Test5()
        {
            var helper = new FuncCalculateHelper();
            double x = -1;

            var ln = helper.Ln(x);

            Assert.IsFalse(Math.Pow(Math.E, ln) == x);
        }

        [TestMethod()]
        public void Ln_Test6()
        {
            var helper = new FuncCalculateHelper();
            double x = -1234.1234;

            var ln = helper.Ln(x);

            Assert.IsFalse(Math.Pow(Math.E, ln) == x);
        }

        [TestMethod()]
        public void Ln_Test7()
        {
            var helper = new FuncCalculateHelper();
            double x = double.MinValue;

            var ln = helper.Ln(x);

            Assert.IsFalse(Math.Pow(Math.E, ln) == x);
        }

        [TestMethod()]
        public void Ln_Test8()
        {
            var helper = new FuncCalculateHelper();
            double x = double.NegativeInfinity;

            var ln = helper.Ln(x);

            Assert.IsFalse(Math.Pow(Math.E, ln) == x);
        }

        [TestMethod()]
        public void Ln_Test9()
        {
            var helper = new FuncCalculateHelper();
            double x = double.PositiveInfinity;

            var ln = helper.Ln(x);

            Assert.IsFalse(Math.Pow(Math.E, ln) == x);
        }

        [TestMethod()]
        public void Ln_Test10()
        {
            var helper = new FuncCalculateHelper();
            double x = -1_000_000_000_000;

            var ln = helper.Ln(x);

            Assert.IsFalse(Math.Pow(Math.E, ln) == x);
        }
    }
}
