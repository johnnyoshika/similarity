using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Similarities
{
    class CompanyNameMatch
    {

        public bool Match(string s1, string s2)
        {
            if (string.IsNullOrWhiteSpace(s1) || string.IsNullOrWhiteSpace(s2))
                return false;

            string shorter = Shorter(s1, s2);
            string longer = Longer(s1, s2);

            var intersection = s1.Words().Intersect(s2.Words());
            if (intersection.Count() == shorter.Words().Count())
                return true;

            if (shorter[0] != longer[0])
                return false;

            return SequentialCharacterMatch(longer, shorter);
        }

        bool SequentialCharacterMatch(string longer, string shorter)
        {
            var index = longer.IndexOf(shorter[0]);
            if (index == -1)
                return false;

            if (shorter.Count() == 1)
                return true;

            return SequentialCharacterMatch(longer.Substring(index+1), shorter.Substring(1));
        }

        string Shorter(string s1, string s2)
        {
            if (s1 == null)
                return s1;

            if (s2 == null)
                return s2;

            return s1.Count() < s2.Count() ? s1 : s2;
        }

        string Longer(string s1, string s2)
        {
            if (s1 == null)
                return s2;

            if (s2 == null)
                return s1;

            return s1.Count() < s2.Count() ? s2 : s1;
        }

    }
}
