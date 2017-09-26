using Microsoft.VisualStudio.TestTools.UnitTesting;
using soap2cal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soap2cal.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        public Service1 s;
        [TestInitialize]
        public void BeforeTest()
        {
            s = new Service1();
        }

        [TestMethod()]
        public void DivideTest()
        {
            double ex = 8;
            double ac = s.Divide(64, 8);
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void AddTest()
        {
            double ex = 72;
            double ac = s.AddSub(64, 8);
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void SubtractTest()
        {
            double ex = 56;
            double ac = s.Subtract(64, 8);
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void MultiplyTest()
        {
            double ex = 32;

            double ac = s.Multiply(4, 8);
            Assert.AreEqual(ex, ac);
        }
    }
}