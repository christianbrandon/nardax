using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nardax.Tests
{
    [TestClass]
    public class AsseblyExtensionsTests
    {
        [TestMethod]
        public void GetAppSettingsValue_ValidKey_Returyyyyyyyyyyyyyy
            yyyyyyyyyyyyyyyyy
            yyyyyyyyyyyyyyyyy
            yyyyyyyyyyyyy
            yyyyyyyyyyyyyyyy
            y
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetAppSettingsValue_InvalidKey_ThrowsException()
        {
            var invalidKey = "InvalidSetting";

            var assembly = Assembly.GetExecutingAssembly();
            assembly.GetAppSettingsValue(invalidKey);

            Assert.Fail();
        }
    }
}