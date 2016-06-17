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
            var match = similarity.Match("ACE Program - Portuguese + English Speaking- Service Desk Analyst (24/7 shifts)",Rules() );

            Assert.AreEqual("ACE Program - Portuguese Speaking - Service Desk Analyst(24 / 7 shifts)", match);
        }
        ///<remarks>
        ///Lenenshtein and one and two word match and send it to suggestions
        ///</remarks>
        [TestMethod]
        public void Analytics_Engineer()
        {
            var similarity = new JobTitleSimilarity();
            var match = similarity.Match("Analytics Engineer(Big Data)", Rules());

            Assert.AreEqual("Analytics Engineer", match);
        }
        ///<remarks>
        ///Double check
        ///</remarks>
        [TestMethod]
        public void Principal_Software()
        {
            var similarity = new JobTitleSimilarity();
            var match = similarity.Match("Principal Software Engineer - Backend", Rules());

            Assert.AreEqual("Intermediate Software Engineer - Backend", match);
        }

        ///<remarks>
        ///Double check
        ///</remarks>
        [TestMethod]
        public void Programmer_Analyst()
        {
            var similarity = new JobTitleSimilarity();
            var match = similarity.Match("Programmer Analyst - Data Warehouse Integration",Rules()  );

            Assert.AreEqual("Programmer Analyst", match);
        }

        ///<remarks>
        ///acronym match
        ///</remarks>
        [TestMethod]
        public void DBA()
        {
            var similarity = new JobTitleSimilarity();
            var match = similarity.Match("Senior Oracle Database Administrator",Rules());

            Assert.AreEqual("Senior Oracle DBA", match);
        }

        [TestMethod]
        public void salesforce()
        {
            var similarity = new JobTitleSimilarity();
            var match = similarity.Match("Business Analyst-Salesforce", Rules());

            Assert.AreEqual("Salesforce Analyst", match);
        }

        [TestMethod]
        public void electronics()
        {
            var similarity = new JobTitleSimilarity();
            var match = similarity.Match("Electrical and Electronics Engineering Technologist", Rules());

            Assert.AreEqual("Electronics Engineering Technologist - Lab Tech.", match);
        }

        [TestMethod]
        public void bi()
        {
            var similarity = new JobTitleSimilarity();
            var match = similarity.Match("Business Intelligence Analyst", Rules());

            Assert.AreEqual("Business Intelligence Technical Analyst", match);
        }

        [TestMethod]
        public void ba()
        {
            var similarity = new JobTitleSimilarity();
            var match = similarity.Match("Business System Analyst", Rules());

            Assert.AreEqual("Business Systems Analyst (BSA)", match);
        }

        [TestMethod]
        public void c_sp()
        {
            var similarity = new JobTitleSimilarity();
            var match = similarity.Match("C# Development Support", Rules());

            Assert.AreEqual("C# Developers", match);
        }

        [TestMethod]
        public void director()
        {
            var similarity = new JobTitleSimilarity();
            var match = similarity.Match("Director of Development and Acquisitions", Rules());

            Assert.AreEqual("Director Development Operations", match);
        }

        [TestMethod]
        public void Software()
        {
            var similarity = new JobTitleSimilarity();
            var match = similarity.Match("Software Engineer, Product Testing, Online", Rules());

            Assert.AreEqual("Software Engineer, Product Testing, Server", match);
        }

        [TestMethod]
        public void Tririga()
        {
            var similarity = new JobTitleSimilarity();
            var match = similarity.Match("Tririga Developer & App Support", Rules());

            Assert.AreEqual("Tririga Developer (FC0044503)", match);
        }

        [TestMethod]
        public void Technology()
        {
            var similarity = new JobTitleSimilarity();
            var match = similarity.Match("Technology Architect (OpenStack Cloud Development)", Rules());

            Assert.AreEqual("Technician Research and Development", match);
        }

        [TestMethod]
        public void Web()
        {
            var similarity = new JobTitleSimilarity();
            var match = similarity.Match("Web Programmer", Rules());

            Assert.AreEqual("Web Engineer", match);
        }

        [TestMethod]
        public void Web_portal()
        {
            var similarity = new JobTitleSimilarity();
            var match = similarity.Match("Web Portal Testing",
                "Web Programmer",
                "Web Portal Tester(QA Analyst)"
                );

            Assert.AreEqual("Web Portal Tester( QA Analyst)", match);
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
                "ACE Program - Portuguese Speaking - Service Desk Analyst(24 / 7 shifts)",
                "Access Database Upgrader",
                "Accuracy Control Manager",
                "Active Directory Specialist",
                "Active Directory Specialist",
                "Analytics Engineer",
                "Analyst",
                "Analytics Specialist (Operations Research)",
                "Analyst, Business Systems - Health Information Systems & Services",
                "Analyst / Software Developer",
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
                "Wireless Technician",
                "Big Data Architect",
                "BIM Technician",
                "Building Maintenance Manager",
                "Building Science Field Technician",
                "Business Analyst - Applications",
                "Business Analyst 2",
                "Business Application Specialist",
                "Business Data Analyst",
                "Business Intelligence Developer",
                "Business Support Analyst",
                "Business Systems Analyst (BSA)",
                "C++ Developer",
                "C++ Technical Lead",
                "CAN - Senior Analyst/Developer (IT)",
                "CEO - E-Commerce",
                "Chief Engineer",
                "Cisco Analyst",
                "Civil Engineer I",
                "Client Services Analyst",
                "Compliance Analyst",
                "Programmer Analyst - Java",
                "Programmer Analyst I - TELUS Health (Kelowna)",
                "Programmer Analyst",
                "Programmer / Analyst",
                "Senior Developer Analyst",
                "Senior Developer",
                "Senior Oracle DBA",
                "Senior Operations Manager",
                "Senior Product Developer",
                "Senior Database Administrator",
                "Senior Data Scientist",
                "Senior Development Engineer",
                "Senior Java Developers",
                "Principal Software Engineer",
                "Principal Software Development Engineer",
                "Principle QA Engineer",
                "Principle Software Developer - Java",
                "Principal Project Manager",
                "Process Technician",
                "Principal Software Engineer - Android",
                "Intermediate Software Engineer - Backend",
                "Salesforce Analyst",
                "Business Analyst - Strategic Sourcing",
                "Business Analyst (Temporary)",
                "Business Data Analyst",
                "Electronics Engineering Technologist - Lab Tech.",
                "Business Intelligence Architect",
                "Business Intelligence Developer",
                "Business Intelligence Engineer",
                "Business Intelligence Technical Analyst",
                "Business Systems Analyst (BSA) -- All Levels",
                "Business Analyst",
                "C# Developers",
                "C# ASP.Net Web Developer",
                "C# .NET Web Developer",
                "Director Development Operations",
                "Software Engineer, Product Testing, Server",
                "Tririga Developer (FC0044503)",
                "Technician Research and Development",
                "Technology & Systems Administrator",
                "Technology Analyst",
                "Technology Director",
                "Technology Project Manager",
                "Technology Project Manager 2",
                "Technology Research and Design Analyst (Technical Writer)",
                "Technology Specialist 2",
                "Technology Strategy and Architecture Senior Manager",
                "TECHNOLOGY SUPPORT SPECIALIST",
                "Web Engineer",
                "java Programmer"

            };
        }
    }
}
