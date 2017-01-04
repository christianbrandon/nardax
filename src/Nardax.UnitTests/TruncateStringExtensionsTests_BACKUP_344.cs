using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nardax.Tests
{
    [TestClass]
    public class TruncateStringExtensionsTests
    {
        private string _value;

        [TestInitialize]
        public void TestInitialize()
        {
            _value = "123456789";
        }

        [TestMethod]
        public void TruncateLeft_ValueIsLarger_TruncateRemovesLeftSide()
        {
            var expected = "9";

            var result = _value.TruncateLeft(1);
            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TruncateLeft_ValueIsSmaller_TruncateRemovesLeftSide()
        {
            var expected = "123456789";

            var result = _value.TruncateLeft(20);

            Assert.AreEqual(expected, result);
        }
       
        [TestMethod]
        public void TruncateRight_ValueIsLarger_TruncateRemovesRightSide()
        {
            var expected = "1";

            var result = _value.TruncateRight(1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TruncateRight_ValueIsSmaller_TruncateRemovesRightSide()
        {
            var expected = "123456789";

            var result = _value.TruncateRight(20);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TruncateRight_ValueIsLarger_TruncateRemovesRightSide()
        {
            var expected = "1";

            var result = _value.TruncateRight(1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TruncateRight_ValueIsSmaller_TruncateRemovesRightSide()
        {
            var expected = "123456789";

            var result = _value.TruncateRight(20);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TruncateRight_ValueIsLarger_TruncateRemovesRightSide()
        {
            var expected = "1";

            var result = _value.TruncateRight(1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TruncateRight_ValueIsSmaller_TruncateRemovesRightSide()
        {
            var expected = "123456789";

            var result = _value.TruncateRight(20);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
<<<<<<< HEAD
        public void RepeatMe()
        {
            var expected = "käbbelkäbbelkäbbel";
            var result = "käbbel".RepeatMe(3);

            Assert.AreEqual(expected, result);


=======
        public void RemoveWhiteChars()
        {
            var testString = "i\twill \tsurvive\t";

            var result = testString.RemoveWhiteChars();
            var expected = "iwillsurvive";

            Assert.AreEqual(expected, result);
>>>>>>> 458d2e8140c9a03e7a9e45d5ef86d69e3ff3dbbf
        }
    }
}
