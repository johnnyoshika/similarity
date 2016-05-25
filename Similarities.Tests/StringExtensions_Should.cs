using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Similarities;

namespace Similarities.Tests
{
    [TestClass]
    public class StringExtensions_Should
    {
        [TestMethod]
        public void Stem_Words()
        {
            string s = "running";
            string result = s.Stem();

            Assert.AreEqual("run", result);
        }

        [TestMethod]
        public void Strip_Stopwords()
        {
            string s = "go to mall";
            string result = s.StripStopwords();

            Assert.AreEqual("go mall", result);
        }

        [TestMethod]
        public void Strip_Punctuations()
        {
            string s = "foo,bar";
            string result = s.StripPunctuations();

            Assert.AreEqual("foo bar", result);
        }
    }
}
