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
                .Select(s => new { Original = s, Score = Score(Process(s), Process(check)) })
                .OrderByDescending(s => s.Score)
                .ThenBy(s => s.Original.Length)
                .ThenBy(s => s.Original.ToLower())
                .ToArray();

            if (rank.Count() == 0)
                return null;

            if (rank.First().Score >= 0.65)
                return rank.First().Original;
            else
                return null;
        }

        protected abstract double Score(string s1, string s2);
    }

    public class JobTitleSimilarity : Similarity
    {
        protected override string Process(string s)
        {
            return s
                .StripStopwords()
                .StripPunctuations();
        }

        protected override double Score(string s1, string s2)
        {
            return s1.JaccardIndex(s2);
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

        protected override double Score(string s1, string s2)
        {
            return s1.JaccardIndex(s2);
        }
    }

    public class CompanyNameSimilarity : Similarity
    {
        protected override string Process(string s)
        {
            return s
                .StripPunctuations();
        }

        protected override double Score(string s1, string s2)
        {
            return new SequentialCharacterMatch().Score(s1, s2);
        }
    }

}
