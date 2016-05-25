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
                .OrderByDescending(s => s.Score);

            if (rank.Count() == 0)
                return null;

            if (rank.First().Score > 0.85)
                return rank.First().Original;
            else
                return null;
        }

        double Result(string s1, string s2)
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
    }

    public class CompanyNameSimilarity : Similarity
    {
        protected override string Process(string s)
        {
            return s
                .StripPunctuations()
                .Stem();
        }
    }


}
