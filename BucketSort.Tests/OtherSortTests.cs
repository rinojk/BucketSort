using System;
using System.Collections.Generic;
using BucketSort.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BucketSort.Tests
{
    [TestClass]
    public class OtherSortTests
    {
        private OtherSorts otherSort;

        public OtherSortTests()
        {
            otherSort = new OtherSorts();
        }

        [TestMethod]
        public void Sort_TakeNull_ThrowException()
        {
            try
            {
                otherSort.BubbleSortList(null);
            }
            catch (Exception e)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Sort_TakeEmptyArr_ReturnEmpty()
        {
            var res = String.Join(", ", otherSort.BubbleSortList(new List<int>() { }));
            Assert.AreEqual(res, "");
        }

        [TestMethod]
        public void Sort_TakeOneArray_ReturnElement()
        {
            var res = String.Join(", ", otherSort.BubbleSortList(new List<int>() { 0 }));
            Assert.AreEqual(res, "0");
        }
    }
}
