using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Set;

namespace UnitTests
{
    [TestClass]
    public class SetAddTests
    {
        [TestMethod]
        public void New_Set_Has_Zero_Length()
        {
            var set = new Set<object>();
            int expectedLength = 0;

            int actualLength = set.Count;

            Assert.AreEqual(expectedLength, actualLength);
        }

        [TestMethod]
        public void Can_Add_Single_Item()
        {
            var set = new Set<object>();
            var input = new object();
            int expectedLength = 1;

            set.Add(input);
            int actualLength = set.Count;

            Assert.AreEqual(expectedLength, actualLength);
        }

        [TestMethod]
        public void Does_Not_Add_Same_Reference_Type_Twice()
        {
            var set = new Set<object>();
            var input = new object();
            int expectedLength = 1;

            set.Add(input);
            set.Add(input);
            int actualLength = set.Count;

            Assert.AreEqual(expectedLength, actualLength);
        }

        [TestMethod]
        public void Does_Not_Add_Same_Value_Type_Twice()
        {
            var set = new Set<int>();
            var input = 42;
            int expectedLength = 1;

            set.Add(input);
            set.Add(input);
            int actualLength = set.Count;

            Assert.AreEqual(expectedLength, actualLength);
        }

        // Add multiple objects

        [TestMethod]
        public void Can_Add_Array()
        {
            var set = new Set<int>();
            int[] input = {1, 2, 3, 4, 5};
            var expected = new Set<int> {1, 2, 3, 4, 5};

            set.Add(input);

            Assert.IsTrue(set.EqualTo(expected));
        }

        [TestMethod]
        public void Can_Add_List()
        {
            var set = new Set<int>();
            var input = new List<int> {1, 2, 3, 4, 5};
            var expected = new Set<int> { 1, 2, 3, 4, 5 };

            set.Add(input);

            Assert.IsTrue(set.EqualTo(expected));
        }

        [TestMethod]
        public void Can_Add_Via_Delegate()
        {
            var set = new Set<int>();
            int[] input = {1, 2, 3, 4, 5};
            var expected = new Set<int> {2, 4};

            set.Add(input, (i) => i % 2 == 0);

            Assert.IsTrue(set.EqualTo(expected));
        }
    }
}
