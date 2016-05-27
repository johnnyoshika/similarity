using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Similarities;

namespace Similarities.Tests
{
    [TestClass]
    public class CompanyNameSimilarity_Should
    {
        ///<remarks>
        ///Acronym mismatch.
        ///</remarks>
        [TestMethod]
        public void Match_Similar_Names()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match("IBM", "IBM");

            Assert.AreEqual("International Business Machines", match);
        }
        ///<remarks>
        ///Remove commas,dot,slash,comapare as lower case strings.
        ///</remarks>
        [TestMethod]
        public void AbeBooks()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match("AbeBooks Inc.",
                "AbeBooks, an Amazon company",
                "Abebooks.com",
                "Abebooks.com, an Amazon company"
            );

            Assert.AreEqual("AbeBooks, an Amazon company", match);
        }
        ///<remarks>
        ///Double check,always compare with string of smaller length
        ///</remarks>
        [TestMethod]
        public void GlobalRelay()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match("GLOBAL RELAY COMMUNICATIONS INC","Global Relay"
            );

            Assert.AreEqual("Global Relay", match);
        }

        [TestMethod]
        public void Amazon()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match("AMZN CAN Fulfillment Svcs, Inc","Amazon Canada Fulfillment Services Inc.",
                "Amazon Canada Fulfillment Services, Inc","Amazon Canada Fulfillment Services, Inc.",
                "Amazon Web Services",
                "AMZN CAN Fulfillment Svcs, Inc."
            );

            Assert.AreEqual("Amazon Canada Fulfillment Services, Inc", match);
        }
        ///<remarks>
        ///check for first word match with least similarity score and avoid when there is priority clash
        ///</remarks>
        [TestMethod]
        public void enCompass()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match("enCompass Data Solutions",
                "enCompass Solutions Group"
            );

            Assert.AreEqual("enCompass Solutions Group", match);
        }
        ///<remarks>
        ///Check for question mark without space.
        ///</remarks>
        [TestMethod]
        public void executrade()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match("Executrade – Your Recruitment Specialists",
                "Executrade ? Your Recruitment Specialists"
            );

            Assert.AreEqual("Executrade ? Your Recruitment Specialists", match);
        }

        ///<remarks>
        ///Double check
        ///</remarks>
        [TestMethod]
        public void Falcon()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match("Falcon Software Company, Inc.",
                "Falcon - Software"
            );

            Assert.AreEqual("Falcon - Software", match);
        }

        ///<remarks>
        ///If first word matches and smallest word is of length > 2 ,then check for second word and return score 0.8
        ///</remarks>
        [TestMethod]
        public void Weston_Bakeries()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match("Weston Bakeries Ltd./ Savoury Foods",
                "Weston Bakeries Limited"
            );

            Assert.AreEqual("Weston Bakeries Limited", match);
        }

    }
}
