using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tribonacci_Sequence
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            Program program = new Program();
            Assert.AreEqual(new double[] {0}, program.Tribonacci(new double[] { 1, 1, 1 }, 0));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Program program = new Program();
            Assert.AreEqual(new double[] {1}, program.Tribonacci(new double[] { 1 }, 1));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Program program = new Program();
            Assert.AreEqual(new double[] { 1,1}, program.Tribonacci(new double[] { 1 , 1, 1}, 2));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Program program = new Program();
            Assert.AreEqual(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, program.Tribonacci(new double[] { 1, 1, 1 }, 10));
        }
    }
}
