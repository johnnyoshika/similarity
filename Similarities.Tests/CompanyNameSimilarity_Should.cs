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
            var match = similarity.Match("IBM", Rules());

            Assert.AreEqual("International Business Machines", match);
        }
        ///<remarks>
        ///Remove commas,dot,slash,comapare as lower case strings.
        ///</remarks>
        [TestMethod]
        public void AbeBooks()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match("AbeBooks Inc.", Rules());

            Assert.AreEqual("Abebooks.com", match);
        }
        ///<remarks>
        ///Double check,always compare with string of smaller length
        ///</remarks>
        [TestMethod]
        public void GlobalRelay()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match("GLOBAL RELAY COMMUNICATIONS INC", Rules());

            Assert.AreEqual("Global Relay", match);
        }

        [TestMethod]
        public void Amazon()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match("AMZN CAN Fulfillment Svcs, Inc", Rules());

            Assert.AreEqual("Amazon Canada Fulfillment Services Inc.", match);
        }
        ///<remarks>
        ///check for first word match with least similarity score and avoid when there is priority clash
        ///</remarks>
        [TestMethod]
        public void enCompass()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match("enCompass Data Solutions", Rules());

            Assert.AreEqual("enCompass Solutions Group", match);
        }
        ///<remarks>
        ///Check for question mark without space.
        ///</remarks>
        [TestMethod]
        public void executrade()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match("Executrade – Your Recruitment Specialists", Rules());

            Assert.AreEqual("Executrade ? Your Recruitment Specialists", match);
        }

        ///<remarks>
        ///Double check
        ///</remarks>
        [TestMethod]
        public void Falcon()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match("Falcon Software Company, Inc.", Rules());

            Assert.AreEqual("Falcon - Software", match);
        }

        ///<remarks>
        ///If first word matches and smallest word is of length > 2 ,then check for second word and return score 0.8
        ///</remarks>
        [TestMethod]
        public void Weston_Bakeries()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match("Weston Bakeries Ltd./ Savoury Foods", Rules());

            Assert.AreEqual("Weston Bakeries Limited", match);
        }

        string[] Rules()
        {
            return new[]
            {
                "International Business Machines",
                "AbeBooks, an Amazon company",
                "Abebooks.com",
                "Abebooks.com, an Amazon company",
                "Global Relay",
                "Amazon Canada Fulfillment Services, Inc.",
                "Amazon Canada Fulfillment Services Inc.",
                "Amazon Canada Fulfillment Services, Inc",
                "Amazon Web Services",
                "enCompass Solutions Group",
                "Executrade ? Your Recruitment Specialists",
                "Falcon - Software",
                "Weston Bakeries Limited",
                "BMC Software",
                "Deloitte Canada",
                "Fortinet",
                "Global Relay",
                "HERE",
                "Hyperwallet",
                "ISM CANADA",
                "Logibec",
                "Modis",
                "OneMedNet",
                "Point Grey",
                "Quick Mobile",
                "Reliable Controls",
                "Safe Software Inc.",
                "Samsung Electronics Canada",
                "Seon",
                "SPEEDLINE SOLUTIONS, INC.",
                "TEEMA Solutions Group",
                "TNI PrimeTime Promotions Inc",
                "Transparent Solutions Corp.",
                "WaterTrax",
                "Whitewater West Industries",
                "ZE PowerGroup",
                "LOGIBEC INC",
                "Intel Corporation",
                "MediaValet",
                "Nikls",
                "Payfirma Corporation",
                "Ping Identity",
                "Primetime Promotions Inc",
                "Qube Buildings Ltd",
                "Seaspan",
                "Sysorex",
                "Texture",
                "Trimble",
                "Vision 7 International",
                "Weston Foods Canada",
                "xMatters",
                "ZincNyx Energy Solutions Inc.",
                "Viking Air Ltd",
                "SNC - Lavalin",
                "Radware",
                "OneMedNet",
                "McElhanney",
                "lululemon athletica",
                "Inuktun Services",
                "Industrial Alliance",
                "Graham",
                "Fluxwerx",
                "dpointtechnologies",
                "Cymax Stores Inc.",
                "Codan Radio Communications",
                "Buyatab Online Inc."
            };
        }
    }
}
