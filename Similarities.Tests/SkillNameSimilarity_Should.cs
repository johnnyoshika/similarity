using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Similarities;

namespace Similarities.Tests
{
    [TestClass]
    public class SkillNameSimilarity_Should
    {

        ///<remarks>
        ///check for first word match with least similarity score and avoid when there is priority clash
        ///</remarks>
        [TestMethod]
        public void Match_Similar_Names()
        {
            var similarity = new SkillNameSimilarity();
            var match = similarity.Match("JavaScript Web Developer", Rules());

            Assert.AreEqual("JavaScript/ASP.NET Web Developer", match);
        }
        ///<remarks>
        ///check for word match
        ///</remarks>
        [TestMethod]
        public void Programmer_Analyst()
        {
            var similarity = new SkillNameSimilarity();
            var match = similarity.Match(".NET 2.0",
                ".NET 3.0",
                ".NET 3.5",
                ".NET 4.0"
            );

            Assert.AreEqual(".NET 3.0", match);
        }

        ///<remarks>
        ///check for levenshtein distance and and if it is more than a limit check for first word match and further two word macth if the string is of length >=3 
        ///</remarks>
        [TestMethod]
        public void CIVIL()
        {
            var similarity = new SkillNameSimilarity();
            var match = similarity.Match("CIVIL CONSTRUCTION",
                "CIVIL DESIGN",
                "CIVIL DRAFTING",
                "CIVIL EIT",
                "CIVIL ENGINEER",
                "CIVIL ENGINEERING",
                "civil engineering construction",
                "CIVIL ENGINEERING DEGREE",
                "CIVIL ENGINEERING DESIGN",
                "CIVIL ENGINEERING LAND DEVELOPMENT",
                "CIVIL ENGINEERS");

            Assert.AreEqual("civil engineering construction", match);
        }

        ///<remarks>
        ///check for removal of numeric values
        ///</remarks>
        [TestMethod]
        public void Microsoft()
        {
            var similarity = new SkillNameSimilarity();
            var match = similarity.Match("MICROSOFT EXCEL",
                "MICROSOFT OFFICE",
                "MICROSOFT OFFICE 2000",
                "MICROSOFT OFFICE 2003");

            Assert.AreEqual("MICROSOFT OFFICE", match);
        }

        ///<remarks>
        ///levenshtein
        ///</remarks>
        [TestMethod]
        public void TROUBLESHOOT()
        {
            var similarity = new SkillNameSimilarity();
            var match = similarity.Match("TROUBLESHOOT/DIAGNOSE",
                "TROUBLESHOOT / MAINTAIN",
                "TROUBLE - SHOOTING",
                "TROUBLE-SHOOT");

            Assert.AreEqual("TROUBLESHOOT / MAINTAIN", match);
        }
        ///<remarks>
        ///levenshtein
        ///</remarks>
        [TestMethod]
        public void data()
        {
            var similarity = new SkillNameSimilarity();
            var match = similarity.Match("DATA CLEANSING",
                "DATA CLEANING");

            Assert.AreEqual("DATA CLEANING", match);
        }
        ///<remarks>
        ///levenshtein
        ///</remarks>
        [TestMethod]
        public void data_analy()
        {
            var similarity = new SkillNameSimilarity();
            var match = similarity.Match("DATA ANALYSIS",
                "DATA ANALYTICS",
                "DATA ANALYST");

            Assert.AreEqual("DATA ANALYST", match);
        }


        string[] Rules()
        {
            return new[]
            {
                "[1516-12] Web Developer",
                "1 Web developer",
                "APPLICATION : MWI / WEB DEVELOPER (July 2015)",
                "Back End Web Developer(s)",
                "Back End/Full Stack Web Developer",
                "Backend Web Developer",
                "Back-End Web Developer",
                "C# .NET Web Developer",
                "C# .NET Web Developer - Intermediate or Senior",
                "C# .NET Web Developer ? Cloud Development",
                "C# ASP.Net Web Developer",
                "C#/ASP.NET Web Developer - Pro Sports & Entertainment",
                "Contract Web Developer  #1748",
                "Contract Web Developer #1748",
                "Embedded Software Web Developer",
                "Embedded Web Developer - Contract",
                "Full Stack Web Developer",
                "Full Stack Web Developer (contract)",
                "Full Stack Web Developer (Job ID: 7990)",
                "Full Stack Web Developer(JN10072015)",
                "Full Stack Web Engineer",
                "Full-stack Web Developer",
                "Full-stack Web Engineer",
                "Graphic Designer/Web Developer",
                "Information Technology Professional II (Web Solutions Developer) - Competition #013",
                "Int. Web Developer",
                "Intermediate / Senior Web Developer",
                "Intermediate / Sr Web Developer",
                "Intermediate / Sr Web Developer (CARD1001, CARD1012)",
                "Intermediate / Sr Web Developer (CARD1012)",
                "Intermediate Full Stack Web Developer",
                "Intermediate Full Stack Web Developer (Full -Time)",
                "Intermediate Web Designer (contract)",
                "Intermediate Web Developer",
                "Intermediate Web Developer  #1785",
                "Intermediate Web Developer #1693",
                "Intermediate Web Developer #1785",
                "Intermediate Web Developer (Front-end)",
                "Intermediate Web Developer (Marketing Team)",
                "JavaScript/ASP.NET Web Developer",
                "Jr. / Int. Web Developers",
                "Jr. / Int. Web Developers (CARD1010, CARD1011)",
                "Jr. / Int. Web Developers (CARD1010, CARD1011) (Duplicate)",
                "Jr. / Int. Web Developers (CARD1011)",
                "Junior and Intermediate Web Developers (B.C.) #1724",
                "Junior Software & Web Developer",
                "Junior Software and Web Developer",
                "Junior Web Developer",
                "Lead Web Applications Developer",
                "Lead Web Developer",
                "Senior ASP.NET MVC Web Developer",
                "Senior Full Stack Web Developer for Direct Response Marketing Company",
                "Senior Software Engineer (Web)",
                "Senior Web Application Developer",
                "Senior Web Client Developer",
                "Senior Web Developer",
                "Senior Web Developer (CARD846)",
                "Senior Web Developer AngularJS/Node.js",
                "Senior Web/Windows Developer",
                "Senior/Intermediate Web Developer",
                "Software Developer - Web and Mobile",
                "Software Developer - Website Acceleration",
                "Software Developer ? Intermediate/Senior Web Applications (SC-36)",
                "Software Developer Web",
                "Software Developer -Website Acceleration",
                "Software Engineer - Full Stack Web Developer",
                "Sr. Web Developer",
                "Talented Web Developer (Vancouver)",
                "Team Lead, Web Development (CARD846)",
                "Web / Mobile Developer",
                "Web / Mobile Developer (Job ID: 8166)",
                "Web Administrator and Developer",
                "Web Administrator and Development Specialist",
                "Web Application Developer",
                "Web Application Developer - Contract",
                "Web Application Developer - Management Console",
                "Web Application Developer - Windows (CARD797)",
                "Web Application Developer #1695",
                "Web Application Developer &amp; Designer",
                "Web Application Developer [Senior]",
                "Web Application Developers",
                "Web Application Developers - (Full Stack/Front-End)",
                "Web Application Engineer",
                "Web Application UI/UX Developer - Vonigo",
                "Web Compatibility Engineer",
                "Web Designer/Developer",
                "Web Developer",
                "Web Developer - Internship",
                "Web Developer - Mobile",
                "Web Developer & Designer",
                "Web Developer (#T16001)",
                "Web Developer (AngularJS)",
                "WEB DEVELOPER (Consolidated)",
                "Web Developer (Co-op)",
                "Web Developer (JavaScript, HTML5, CSS3)",
                "Web Developer (Joining Mobile Team) #1740",
                "Web Developer (Server-Side)",
                "Web Developer (T16002)",
                "Web Developer (x3) - User Interface",
                "Web Developer / Mentor",
                "Web Developer 1 (CARD949)",
                "Web Developer 2 (CARD2000)",
                "Web Developer 2 (CARD2001)",
                "Web Developer 2 (CARD951)",
                "Web Developer 2016",
                "Web Developer 3",
                "Web Developer and Tech Support",
                "Web Developer for Head Worn Devices(Recon Instruments)",
                "Web Developer for Typo3 / PHP / JAVASCRIPT",
                "Web Developer with HP TeamSite Expertise #1742",
                "Web Developer, Professional Services Team",
                "Web Developers",
                "Web Developers (CARD825)",
                "Web Developers (CARD825, CARD1010, CARD1011)",
                "Web Developers (FortiGate)",
                "WEB DEVELOPERS FOR HTML5 & JAVASCRIPT",
                "Web development",
                "Web Development Engineer",
                "Web Development Engineer - Vendor Express",
                "Web Development Engineer II",
                "Web Development Engineer II (Senior)",
                "Web Development Software Engineer",
                "Web Engineer",
                "Web Engineer, Website Operations and Development",
                "Web Infrastructure Developer (DevOps)",
                "Web Programmer",
                "Web Software Developer",
                "Web/HTML developer",
                "Website Developer"
            };
        }
    }
}
