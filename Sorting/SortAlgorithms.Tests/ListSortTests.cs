using NUnit.Framework;
using SortAlgorithms.Core;

namespace SortAlgorithms.Tests
{
    [TestFixture]
    class ListSortTests
    {
        [Test]
        public void Sort10Elements()
        {
            var arr = new int[] { 3, 2, 6, 5, 7, 9, 8, 4, 1, 0 };
            var algorithm = new ListSort();
            var result = algorithm.Sort(arr);

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
            Assert.AreEqual(2, result[2]);
            Assert.AreEqual(3, result[3]);
            Assert.AreEqual(4, result[4]);
            Assert.AreEqual(5, result[5]);
            Assert.AreEqual(6, result[6]);
            Assert.AreEqual(7, result[7]);
            Assert.AreEqual(8, result[8]);
            Assert.AreEqual(9, result[9]);
        }

        [Test]
        public void FaultyTest()
        {
            Assert.AreEqual(false, true);
        }
    }
}
