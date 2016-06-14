using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Similarities
{
    public static class WordExtensions
    {
        public static string[] Unique(this string[] words)
        {
            var uniques = new List<string>();
            foreach (var word in words)
                if (!uniques.Contains(word))
                    uniques.Add(word);

            return uniques.ToArray();
        }

        public static string[] Words(this string phrase)
        {
            return phrase
                .ToLower()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Unique();
        }
    }
}
