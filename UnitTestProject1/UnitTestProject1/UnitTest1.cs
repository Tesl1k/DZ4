using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>() { 1, 2, 3, 4 };
        List<int> list3 = new List<int>() { 2, 4 };

        [TestMethod]
        public void TestMethod1()
        {
            Assert.ReferenceEquals(list1, Class1.Method(new List<int>()));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.ReferenceEquals(list2, Class1.Method(list3));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.ReferenceEquals(list2, Class1.Method(list2));
        }
    }
}
