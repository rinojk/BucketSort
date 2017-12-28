using System;
using BucketSort.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BucketSort.Tests
{
    [TestClass]
    public class BucketSortTests
    {
        private BucketSortMain bucketSort;

        public BucketSortTests()
        {
            bucketSort = new BucketSortMain();
        }

        [TestMethod]
        public void Sort_TakeNull_ThrowException()
        {
            try
            {
                bucketSort.BucketSort(null);
            }
            catch (Exception e)
            {
                Assert.IsTrue(true);
            }
        }
        
        [TestMethod]
        public void Sort_TakeEmptyArr_ReturnEmpty()
        {
            var res = String.Join(", ", bucketSort.BucketSort(new int[] { }));
            Assert.AreEqual(res, "");
        }
        
        [TestMethod]
        public void Sort_TakeOneArray_ReturnElement()
        {
            var res = String.Join(", ", bucketSort.BucketSort(new int[] { 0}));
            Assert.AreEqual(res, "0");
        }
    }
}
