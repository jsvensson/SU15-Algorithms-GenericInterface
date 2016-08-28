using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Set;

namespace UnitTests
{
    [TestClass]
    public class SetCopyTests
    {
        private Set<int> set;

        [TestInitialize]
        public void Initialize()
        {
            set = new Set<int> {1, 2, 3, 4, 5};
        }

        [TestMethod]
        public void Copies_Set()
        {
            ISet<int> actual = set.Copy();

            Assert.IsTrue(actual.EqualTo(set));
        }
    }
}
