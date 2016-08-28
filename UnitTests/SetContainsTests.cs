using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Set;

namespace UnitTests
{
    [TestClass]
    public class SetContainsTests
    {
        private Set<int> set;

        [TestInitialize]
        public void Initialize()
        {
            set = new Set<int> {1, 2, 3, 4, 5};
        }

        [TestMethod]
        public void Set_Contains_Item()
        {
            int expected = 3;

            Assert.IsTrue(set.Contains(expected));
        }

        [TestMethod]
        public void Set_Does_Not_Contain_Item()
        {
            int expected = 343;

            Assert.IsFalse(set.Contains(expected));
        }
    }
}
