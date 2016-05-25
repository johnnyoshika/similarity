﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Similarities;

namespace Similarities.Tests
{
    [TestClass]
    public class CompanyNameSimilarity_Should
    {
        [TestMethod]
        public void Match_Similar_Names()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match("International Business Machines", "IBM");

            Assert.AreEqual("IBM", match);
        }
    }
}
