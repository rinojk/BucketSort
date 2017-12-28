using System;
using BucketSort.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BucketSort.Tests
{
    [TestClass]
    public class MainTests
    {
        private int[] ascArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private int[] descArr = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        private int[] uniformArr = new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
        private int[] arbitraryArr = new int[] { 5, 3, 6, 7, 2, 1, 4, 10, 8, 9, 3, 2, 7 };

        private string sortedAscArr = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10";
        private string sortedDescArr = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10";
        private string sortedUniformArr = "5, 5, 5, 5, 5, 5, 5, 5, 5, 5";
        private string sortedArbitraryArr = "1, 2, 2, 3, 3, 4, 5, 6, 7, 7, 8, 9, 10";

        private BucketSortMain bucketSort;

        public MainTests()
        {
            bucketSort = new BucketSortMain();
        }

        [TestMethod]
        public void SortAscArrTest()
        {
            string res = String.Join(", ", bucketSort.BucketSort(ascArr));
            Assert.AreEqual(res, sortedAscArr);
        }
        [TestMethod]
        public void SortDescArrTest()
        {
            string res = String.Join(", ", bucketSort.BucketSort(descArr));
            Assert.AreEqual(res, sortedDescArr);
        }
        [TestMethod]
        public void SortUniformArrTest()
        {
            string res = String.Join(", ", bucketSort.BucketSort(uniformArr));
            Assert.AreEqual(res, sortedUniformArr);
        }
        [TestMethod]
        public void SortArbitraryArrTest()
        {
            string res = String.Join(", ", bucketSort.BucketSort(arbitraryArr));
            Assert.AreEqual(res, sortedArbitraryArr);
        }

    }
}
