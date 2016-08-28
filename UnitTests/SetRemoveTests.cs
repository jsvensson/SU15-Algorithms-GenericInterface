using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Set;

namespace UnitTests
{
    [TestClass]
    public class SetRemoveTests
    {
        private Set<int> set;

        [TestInitialize]
        public void Initialize()
        {
            set = new Set<int> {1, 2, 3, 4, 5};
        }

        [TestMethod]
        public void Removes_Item()
        {
            int intToRemove = 3;

            set.Remove(intToRemove);

            Assert.IsFalse(set.Contains(intToRemove));
        }

        [TestMethod]
        public void Item_Not_In_Set()
        {
            int expectedLength = 5;

            set.Remove(343);
            int actualLength = set.Count;

            Assert.AreEqual(expectedLength, actualLength);
        }

    }
}
