using FuzzyString;
using System;
using System.Linq;

namespace Similarities
{
    public abstract class Similarity
    {
        protected abstract string Process(string s);

        public string Match(string check, params string[] sources)
        {
            var rank = sources
                .Select(s => new { Original = s, Score = Result(Process(s), Process(check)) })
                .OrderByDescending(s => s.Score)
                .ThenBy(s => s.Original.Length)
                .ThenBy(s => s.Original.ToLower())
                .ToArray();

            if (rank.Count() == 0)
                return null;

            if (rank.First().Score >= 0.8)
                return rank.First().Original;
            else
                return null;
        }

        protected virtual double Result(string s1, string s2)
        {
            return s1.JaccardIndex(s2);
        }
    }

    public class JobTitleSimilarity : Similarity
    {
        protected override string Process(string s)
        {
            return s
                .StripStopwords()
                .StripPunctuations()
                .Stem();
        }
    }

    public class SkillNameSimilarity : Similarity
    {
        protected override string Process(string s)
        {
            return s
                .StripStopwords()
                .StripPunctuations()
                .Stem();
        }
    }

    public class CompanyNameSimilarity : Similarity
    {
        protected override string Process(string s)
        {
            return s
                .StripPunctuations();
        }

        protected override double Result(string s1, string s2)
        {
            return new CompanyNameMatch().Score(s1, s2);
        }
    }

}
