using Annytab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Similarities
{
    public static class StringExtensions
    {
        public static string Stem(this string s)
        {
            var stemmer = new EnglishStemmer();
            return stemmer.GetSteamWord(s);
        }

        public static string StripPunctuations(this string s)
        {
            return Regex.Replace(s, @"[^\w\s]", " ");
        }

        public static string StripSpaces(this string s)
        {
            return s.Replace(" ", string.Empty);
        }

        public static string StripStopwords(this string s)
        {
            var stopwords = new[]
            {
                "a",
                "an",
                "and",
                "are",
                "as",
                "at",
                "be",
                "but",
                "by",
                "for",
                "if",
                "in",
                "into",
                "is",
                "it",
                "no",
                "not",
                "of",
                "on",
                "or",
                "such",
                "that",
                "the",
                "their",
                "then",
                "there",
                "these",
                "they",
                "this",
                "to",
                "was",
                "will",
                "with"
            };

            var words =
                s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Except(stopwords);

            return string.Join(" ", words);
        }
    }
}
