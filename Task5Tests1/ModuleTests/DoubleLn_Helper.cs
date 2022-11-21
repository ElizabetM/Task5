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
    public class DoubleLn_Helper
    {
        private const double MULT_CONST = 2.0;

        [TestMethod()]
        public void DoubleLn_Test1()
        {
            var helper = new FuncCalculateHelper();
            double x = 1;

            Assert.IsTrue(helper.DoubleLn(x) == x * MULT_CONST);
        }

        [TestMethod()]
        public void DoubleLn_Test2()
        {
            var helper = new FuncCalculateHelper();
            double x = 10;

            Assert.IsTrue(helper.DoubleLn(x) == x * MULT_CONST);
        }

        [TestMethod()]
        public void DoubleLn_Test3()
        {
            var helper = new FuncCalculateHelper();
            double x = 0;

            Assert.IsTrue(helper.DoubleLn(x) == x * MULT_CONST);
        }

        [TestMethod()]
        public void DoubleLn_Test4()
        {
            var helper = new FuncCalculateHelper();
            double x = double.MaxValue;

            Assert.IsTrue(helper.DoubleLn(x) == x * MULT_CONST);
        }

        [TestMethod()]
        public void DoubleLn_Test5()
        {
            var helper = new FuncCalculateHelper();
            double x = double.MinValue;

            Assert.IsTrue(helper.DoubleLn(x) == x * MULT_CONST);
        }

        [TestMethod()]
        public void DoubleLn_Test6()
        {
            var helper = new FuncCalculateHelper();
            double x = double.PositiveInfinity;

            Assert.IsFalse(helper.DoubleLn(x) == x * MULT_CONST);
        }

        [TestMethod()]
        public void DoubleLn_Test7()
        {
            var helper = new FuncCalculateHelper();
            double x = double.NegativeInfinity;

            Assert.IsFalse(helper.DoubleLn(x) == x * MULT_CONST);
        }

        [TestMethod()]
        public void DoubleLn_Test8()
        {
            var helper = new FuncCalculateHelper();
            double x = -1234.1234;

            Assert.IsTrue(helper.DoubleLn(x) == x * MULT_CONST);
        }

        [TestMethod()]
        public void DoubleLn_Test9()
        {
            var helper = new FuncCalculateHelper();
            double x = -1;

            Assert.IsTrue(helper.DoubleLn(x) == x * MULT_CONST);
        }

        [TestMethod()]
        public void DoubleLn_Test10()
        {
            var helper = new FuncCalculateHelper();
            double x = -153473546.3215432454;

            Assert.IsTrue(helper.DoubleLn(x) == x * MULT_CONST);
        }
    }
}
