using Binary_Search_Homework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Homework_Test
{
    [TestClass]
    public class HomeworkTest
    {
        [TestMethod]
        public void TestTernarySearch()
        {
            int[] A = { 2, 5, 6, 8, 9, 10 };
            int key = 6;

            int index = BinarySearchHomework.TernarySearch(A, key);

            Assert.AreEqual(2, index);
        }
        
        [TestMethod]
        public void TestGetRepeatTime()
        {
            int[] nums = { 2, 5, 5, 5, 6, 6, 8, 9, 9, 9 };
            int target = 5;

            // pass true for the first occurrence
            int first = BinarySearchHomework.GetRepeatTime(nums, target, true);

            // pass false for the last occurrence
            int last = BinarySearchHomework.GetRepeatTime(nums, target, false);

            int count = last - first + 1;

            Assert.AreEqual(3, count);
        }
    }
}