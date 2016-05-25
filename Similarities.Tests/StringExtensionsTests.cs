using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Similarities;

namespace Similarities.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void Stem_Should_Stem_Words()
        {
            string s = "running";
            string result = s.Stem();

            Assert.AreEqual("run", result);
        }

        [TestMethod]
        public void StripStopwords_Should_Remove_To()
        {
            string s = "go to mall";
            string result = s.StripStopwords();

            Assert.AreEqual("go mall", result);
        }

        [TestMethod]
        public void StripPunctuations_Should_Strip_Commas()
        {
            string s = "foo,bar";
            string result = s.StripPunctuations();

            Assert.AreEqual("foo bar", result);
        }
    }
}
