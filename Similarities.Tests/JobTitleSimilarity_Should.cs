using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Similarities;

namespace Similarities.Tests
{
    [TestClass]
    public class JobTitleSimilarity_Should
    {
        [TestMethod]
        public void Match_Similar_Names()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match(".Net Developer",
                ".Net Framework Developer",
                "C# .Net Developer"
            );

            Assert.AreEqual("C# .Net Developer", match);
        }
    }
}
