using LeetCode_code_review;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestLeetCode
{
    [TestClass]
    public class Test3Sum
    {
        [TestMethod]
        public void CalculateSum()
        {
            _3Sum sum = new _3Sum();
            IList<IList<int>> listToTest = sum.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
            IList<IList<int>> compareList = new List<IList<int>>();
            compareList.Add(new List<int>() { -1, 0, 1 });
            compareList.Add(new List<int>() { -1, -1, 2 });
            Assert.AreEqual(compareList, listToTest);
        }
    }
}
