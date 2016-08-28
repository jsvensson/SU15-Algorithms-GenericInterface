using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Set;

namespace UnitTests
{
    [TestClass]
    public class SetIntersectionWithTests
    {
        private Set<int> setA;

        [TestInitialize]
        public void Initialize()
        {
            setA = new Set<int> { 1, 2, 3, 4, 5 };
        }

        [TestMethod]
        public void Sets_With_Intersection()
        {
            var input = new Set<int> { 4, 5, 6, 7, 8 };
            var expected = new Set<int> { 4, 5 };

            ISet<int> actual = setA.IntersectionWith(input);

            Assert.IsTrue(expected.EqualTo(actual));
        }

        [TestMethod]
        public void Sets_Without_Intersection()
        {
            var input = new Set<int> { 10, 11, 12, 13, 14 };
            var expected = new Set<int>();

            ISet<int> actual = setA.IntersectionWith(input);

            Assert.IsTrue(expected.EqualTo(actual));
        }
    }
}
