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
            var similarity = new JobTitleSimilarity();
            var match = similarity.Match(".NET / SQL Reports Developer (6 Month Contract)", Rules() );

            Assert.AreEqual(".Net Application Developers(C#, SQL)", match);
        }
        ///<remarks>
        ///make one and two word match and send it to suggestions
        ///</remarks>
        [TestMethod]
        public void ACE()
        {
            var similarity = new JobTitleSimilarity();
            var match = similarity.Match("ACE Program - Portuguese + English Speaking- Service Desk Analyst (24/7 shifts)",
                "ACE Program - Portuguese Speaking - Service Desk Analyst(24 / 7 shifts)"
            );

            Assert.AreEqual("ACE Program - Portuguese Speaking - Service Desk Analyst(24 / 7 shifts)", match);
        }
        ///<remarks>
        ///Lenenshtein and one and two word match and send it to suggestions
        ///</remarks>
        [TestMethod]
        public void Analytics_Engineer()
        {
            var similarity = new JobTitleSimilarity();
            var match = similarity.Match("Analytics Engineer(Big Data)",
                "Analytics Engineer"
            );

            Assert.AreEqual("Analytics Engineer", match);
        }
        ///<remarks>
        ///Double check
        ///</remarks>
        [TestMethod]
        public void Principal_Software()
        {
            var similarity = new JobTitleSimilarity();
            var match = similarity.Match("Principal Software Engineer - Backend",
                "Principal Software Engineer - Android"
            );

            Assert.AreEqual("Principal Software Engineer - Android", match);
        }

        ///<remarks>
        ///Double check
        ///</remarks>
        [TestMethod]
        public void Programmer_Analyst()
        {
            var similarity = new JobTitleSimilarity();
            var match = similarity.Match("Programmer Analyst - Data Warehouse Integration",
                "Programmer Analyst - Build Master"
            );

            Assert.AreEqual("Programmer Analyst - Build Master", match);
        }

        ///<remarks>
        ///acronym match
        ///</remarks>
        [TestMethod]
        public void DBA()
        {
            var similarity = new JobTitleSimilarity();
            var match = similarity.Match("Senior Oracle Database Administrator",
                "Senior Oracle DBA"
            );

            Assert.AreEqual("Senior Oracle DBA", match);
        }

        string[] Rules()
        {
            return new[]
            {
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
                ".NET Systems Developer",
                ".Net Web Developer",
                "Access Database Upgrader",
                "Active Directory Specialist",
                "Analytics Engineer",
                "Android Application Developer",
                "API Technical Writer - Messaging Platform",
                "Application Analyst - Vancouver",
                "Application Engineer - Cloud",
                "Application Support Specialist",
                "Apprentice Mechanic",
                "ASP.Net Web Developer",
                "Assoc Director Software Development",
                "Automated QA Analyst",
                "Automation Test Lead",
                "Back End.Net Developer",
                "Mobile Developer",
                "Salesforce Specialist",
                "Customer Support",
                "DevOps Engineer",
                "Mechanical Engineer",
                "IT Support",
                "Performance and Reliability",
                "Research Developer",
                "Interior Designer",
                "Maintenance Manager",
                "Marketing Specialist",
                "Electronics Technologist",
                "Implementation Specialist",
                "General Specialist",
                "Non-Specific Technician Categories",
                "C Software Developer",
                "Security Engineer",
                "Analysis Engineer",
                "Broadcast Engineer",
                "Computer Vision Engineer",
                "Industrial Engineer",
                "Train Control Engineer",
                "Safety Engineer",
                "Detector Assembly Engineer",
                "System Assurance Engineer",
                "Product Development Engineer",
                "Full-Stack Engineer",
                "Mining Engineer",
                "Virtualization Administrator",
                "Access Control Administrator",
                "Environmental Scientist",
                "Electrical  Designer",
                "Program Manager",
                "Infrastructure Analyst",
                "It Security",
                "Human resource officers",
                "Pipefitter installers",
                "Wireless Technician"
            };
        }
    }
}
