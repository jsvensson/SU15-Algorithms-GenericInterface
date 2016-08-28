using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Set;

namespace UnitTests
{
    [TestClass]
    public class SetCountTests
    {
        [TestMethod]
        public void Counts_Items()
        {
            var input = new Set<int> {1, 2, 3, 4, 5};
            int expected = 5;

            int actual = input.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
