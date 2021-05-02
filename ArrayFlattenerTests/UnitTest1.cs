using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ArrayFlattenerTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [Description("The elements' order should be kept for the arrays")]
        public void Flatten_KeepsElementsOrder()
        {
            var values = new[]
            {
                new[] { 1,2 },
                new[] { 3 },
                new[] { 4 }
            };
            CollectionAssert.AreEqual(IntArrayFlattener.Flattener.FlatArrayManually(values), new[] { 1, 2, 3, 4 });

        }

        [TestMethod]
        [Description("An empty array should return an empty array")]
        public void Flatten_EmptyArray_ReturnsEmptyArray()
        {
            var values = new int[][] { };
            Assert.AreEqual(IntArrayFlattener.Flattener.FlatArrayManually(values).Length, 0);
        }
    }
}
