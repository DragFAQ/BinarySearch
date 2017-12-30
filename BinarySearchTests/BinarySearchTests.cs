using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearch;

namespace BinarySearchTests
{
    [TestClass]
    public class SearchEngineTest
    {
        [TestMethod]
        public void SeveralElementsAny()
        {
            Assert.IsTrue(Search.SearchItem(new int[] { 10, 20, 30, 40, 50 }, 40) == 3, "Wrong Index");
        }

        [TestMethod]
        public void SeveralElementsFirst()
        {
            Assert.IsTrue(Search.SearchItem(new int[] { 10, 20, 30, 40, 50 }, 10) == 0, "Wrong Index");
        }

        [TestMethod]
        public void SeveralElementsLast()
        {
            Assert.IsTrue(Search.SearchItem(new int[] { 10, 20, 30, 40, 50 }, 50) == 4, "Wrong Index");
        }

        [TestMethod]
        public void SeveralElementsMid()
        {
            Assert.IsTrue(Search.SearchItem(new int[] { 10, 20, 30, 40, 50 }, 30) == 2, "Wrong Index");
        }

        [TestMethod]
        public void SeveralElementsNotContains()
        {
            Assert.IsTrue(Search.SearchItem(new int[] { 10, 20, 30, 40, 50 }, 25) == -1, "Wrong Index");
        }

        [TestMethod]
        public void SeveralElementsGreaterThenMax()
        {
            Assert.IsTrue(Search.SearchItem(new int[] { 10, 20, 30, 40, 50 }, 60) == -1, "Wrong Index");
        }

        [TestMethod]
        public void SeveralElementsLessThenMin()
        {
            Assert.IsTrue(Search.SearchItem(new int[] { 10, 20, 30, 40, 50 }, 5) == -1, "Wrong Index");
        }

        [TestMethod]
        public void OneElement()
        {
            Assert.IsTrue(Search.SearchItem(new int[] { 10 }, 10) == 0, "Wrong Index");
        }

        [TestMethod]
        public void OneElementNotExists()
        {
            Assert.IsTrue(Search.SearchItem(new int[] { 10 }, 100) == -1, "Wrong Index");
        }

        [TestMethod]
        public void EmptyArray()
        {
            Assert.IsTrue(Search.SearchItem(new int[] { }, 10) == -1, "Wrong Index");
        }

        [TestMethod]
        public void SeveralElementsNotSorted()
        {
            Assert.IsTrue(Search.SearchItem(new int[] { 40, 30, 50, 20, 10 }, 20) == 3, "Wrong Index");
        }
    }
}
