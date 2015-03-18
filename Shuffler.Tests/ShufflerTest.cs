using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shuffler.Tests
{
    [TestClass]
    public class ShufflerTest
    {
        private const int NumberOfItemsInResultArray = 10000;

        private Shuffler _shuffler;
        private int[] _generatedArray;


        [TestInitialize]
        public void TestInitialize()
        {
            _shuffler = new Shuffler();

            _generatedArray = _shuffler.GenerateShuffledArray(NumberOfItemsInResultArray);
        }

        [TestMethod]
        public void ElementsCountTest()
        {
            Assert.IsNotNull(_generatedArray, "Array should not be empty");

            Assert.AreEqual(_generatedArray.Length, NumberOfItemsInResultArray, "Number of elements in generated array incorrect");
        }

        [TestMethod]
        public void UniqunessTest()
        {
            Assert.IsTrue(_generatedArray.Distinct().Count() == _generatedArray.Length, "All elements should be unique");
        }

        [TestMethod]
        public void MaxElementsTest()
        {
            Assert.IsTrue(_generatedArray.Max() == NumberOfItemsInResultArray, "Max value of elemenet in array incorrect");
        }

        [TestMethod]
        public void MinElementTest()
        {
            Assert.IsTrue(_generatedArray.Min() == 1, "Min value of elemenet in array should be 1");
        }
    }
}
