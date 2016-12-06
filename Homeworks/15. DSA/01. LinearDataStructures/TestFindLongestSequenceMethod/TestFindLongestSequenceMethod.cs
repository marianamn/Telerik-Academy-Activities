namespace LongestSubsequenceOfEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TestFindLongestSequenceMethod
    {
        [TestMethod]
        public void TestIfMethodReturnsTheRightResultWithCorrectInputData()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 3, 3, 1, 1 };
            List<int> longestSubsequence = LongestSubsequenceOfEqualNumbers.FindLongestSequence(numbers);
            List<int> expectedSubsequence = new List<int> { 3, 3, 3 };

            Assert.ReferenceEquals(expectedSubsequence, longestSubsequence);
        }

        [TestMethod]
        public void TestIfMethodReturnsMessageWhenThereIsNoSuchSequence()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            List<int> longestSubsequence = LongestSubsequenceOfEqualNumbers.FindLongestSequence(numbers);
            string expectedResult = "There is no sequence with equal elements!";

            Assert.ReferenceEquals(expectedResult, longestSubsequence);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIfMethodThrowsAnExceptionWhenEmptyStringIsInputed()
        {
            List<int> numbers = new List<int> { };
            List<int> longestSubsequence = LongestSubsequenceOfEqualNumbers.FindLongestSequence(numbers);
        }
    }
}
