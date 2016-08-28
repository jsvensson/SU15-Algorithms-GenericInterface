using Microsoft.VisualStudio.TestTools.UnitTesting;
using Set;

namespace UnitTests
{
    [TestClass]
    public class SetUnionWithTests
    {
        private Set<int> setA;
        private Set<int> setB;
        private Set<int> setC;


        [TestInitialize]
        public void Initialize()
        {
            setA = new Set<int> {1, 2, 3, 4, 5};
            setB = new Set<int> {4, 5, 6, 7, 8};
            setC = new Set<int> {10, 11, 12, 13, 14};
        }

        [TestMethod]
        public void Sets_Have_Overlap()
        {
            int[] expected = {1, 2, 3, 4, 5, 6, 7, 8};

            int[] actual = ((Set<int>)setA.UnionWith(setB)).ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sets_Have_No_Overlap()
        {
            int[] expected = {1, 2, 3, 4, 5, 10, 11, 12, 13, 14};

            int[] actual = ((Set<int>)setA.UnionWith(setC)).ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void First_Set_Empty()
        {
            int[] expected = { 1, 2, 3, 4, 5 };

            int[] actual = ((Set<int>)new Set<int>().UnionWith(setA)).ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Second_Set_Empty()
        {
            int[] expected = { 1, 2, 3, 4, 5 };

            int[] actual = ((Set<int>)setA.UnionWith(new Set<int>())).ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Both_Sets_Empty()
        {
            int[] expected = { };

            int[] actual = ((Set<int>)new Set<int>().UnionWith(new Set<int>())).ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }

    }
}
