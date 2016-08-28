using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Set;

namespace UnitTests
{
    [TestClass]
    public class SetEqualToTests
    {
        private Set<int> setA;  // A == B
        private Set<int> setB;
        private Set<int> setC;  // C == A but unordered
        private Set<int> setD;  // D != A

        [TestInitialize]
        public void Initialize()
        {
            setA = new Set<int> { 1, 2, 3, 4, 5 };
            setB = new Set<int> { 1, 2, 3, 4, 5 };
            setC = new Set<int> { 2, 3, 4, 5, 1 };
            setD = new Set<int> { 1, 6, 7, 8, 9 };
        }

        [TestMethod]
        public void Equal_Ordered_Sets()
        {
            Assert.IsTrue(setA.EqualTo(setB));
        }

        [TestMethod]
        public void Equal_Unordered_Sets()
        {
            Assert.IsTrue(setA.EqualTo(setC));
        }

        [TestMethod]
        public void Not_Equal_Sets()
        {
            Assert.IsFalse(setA.EqualTo(setD));
        }

    }
}
