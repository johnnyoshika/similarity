using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Similarities
{
    class SequentialCharacterMatch
    {

        public double Score(string s1, string s2)
        {
            if (string.IsNullOrWhiteSpace(s1) || string.IsNullOrWhiteSpace(s2))
                return 0;

            string shorter = Shorter(s1, s2);
            string longer = Longer(s1, s2);

            var intersection = s1.Words().Intersect(s2.Words());
            if (intersection.Count() == shorter.Words().Count())
                return 1;

            if (shorter[0] != longer[0])
                return 0;

            if(Match(
                longer.ToLower().StripSpaces(), 
                shorter.ToLower().StripSpaces()
            ))
                return 0.9;

            if (string.Equals(s1.Words().First(), s2.Words().First(), StringComparison.OrdinalIgnoreCase))
                return 0.8;

            return 0;
        }

        bool Match(string longer, string shorter)
        {
            var index = longer.IndexOf(shorter[0]);
            if (index == -1)
                return false;

            if (shorter.Count() == 1)
                return true;

            return Match(longer.Substring(index+1), shorter.Substring(1));
        }

        string Shorter(string s1, string s2)
        {
            if (s1 == null)
                return s1;

            if (s2 == null)
                return s2;

            return s1.StripSpaces().Count() < s2.StripSpaces().Count() ? s1 : s2;
        }

        string Longer(string s1, string s2)
        {
            if (s1 == null)
                return s2;

            if (s2 == null)
                return s1;

            return s1.StripSpaces().Count() < s2.StripSpaces().Count() ? s2 : s1;
        }

    }
}
