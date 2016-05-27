using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Similarities;

namespace Similarities.Tests
{
    [TestClass]
    public class JobTitleSimilarity_Should
    {
        ///<remarks>
        ///make one and two word match and send it to suggestions
        ///</remarks>
        [TestMethod]
        public void Match_Similar_Names()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match(".NET / SQL Reports Developer (6 Month Contract)",
".NET / SQL Reports Developer New Westminster or Victoria(Permanent)",
".Net Application Developer",
".Net Application Developers(C#, SQL)",
".Net Developer",
".NET Developer - Contract",
".Net Developer - Enterprise Software Development",
".Net Developer - Fulltime - Vancouver / Victoria",
".Net Developer - High - end software and web solutions!",
".NET Developer - Permanent",
".Net Developer - Vancouver / Toronto / Halifax / Victoria",
".NET Developer(Contract)",
".Net Developer(FC0044376)",
".Net Developer(FC0045552)",
".NET Developer(Permanent)",
".NET Developer(Permanent) - New Westminster",
".NET Developer(Victoria) - Permanent",
".NET Developer Consultant",
".net Developer II",
".NET Developer with experience in Adobe Flash - Permanent",
".NET Developer / Data Conversion for XRM",
  ".Net Developer/ Engineer",
  ".NET Developer / Team Lead - 12 Month Contract",
  ".Net Developers",
  ".NET Developers - Contract and Permanent",
  ".Net Developers - Expanding Team",
  ".NET Developers(3 positions)",
  ".NET Programmer",
  ".NET Programmer Analyst",
  ".NET Programmer Analyst - Full Time - Richmond",
  ".NET Programmer Sr. (Mobile team)",
  ".NET SOA Developer",
  ".Net Software Developer",
  ".NET Software Engineer",
  ".NET Systems Developer"

              ) ;

            Assert.AreEqual(".Net Web Developer", match);
        }
        ///<remarks>
        ///make one and two word match and send it to suggestions
        ///</remarks>
        [TestMethod]
        public void ACE()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match("ACE Program - Portuguese + English Speaking- Service Desk Analyst (24/7 shifts)",
"ACE Program - Portuguese Speaking - Service Desk Analyst(24 / 7 shifts)"
              ) ;

            Assert.AreEqual("ACE Program - Portuguese Speaking - Service Desk Analyst(24 / 7 shifts)", match);
        }
        ///<remarks>
        ///Lenenshtein and one and two word match and send it to suggestions
        ///</remarks>
        [TestMethod]
        public void Analytics_Engineer()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match("Analytics Engineer(Big Data)"
              );

            Assert.AreEqual("Analytics Engineer", match);
        }
        ///<remarks>
        ///Double check
        ///</remarks>
        [TestMethod]
        public void Principal_Software()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match("Principal Software Engineer - Backend");

            Assert.AreEqual("Principal Software Engineer - Android",match);
        }

        ///<remarks>
        ///Double check
        ///</remarks>
        [TestMethod]
        public void Programmer_Analyst()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match("Programmer Analyst - Data Warehouse Integration");

            Assert.AreEqual("Programmer Analyst - Build Master", match);
        }

        ///<remarks>
        ///acronym match
        ///</remarks>
        [TestMethod]
        public void DBA()
        {
            var similarity = new CompanyNameSimilarity();
            var match = similarity.Match("Senior Oracle Database Administrator");

            Assert.AreEqual("Senior Oracle DBA", match);
        }


    }
}
