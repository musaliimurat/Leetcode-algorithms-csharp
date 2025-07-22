using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class GroupAnagram
    {
        public static IList<IList<string>> GroupAnagrams(string[] args)
        {
            Dictionary<string, List<string>> dict = new();

            foreach(var word in args)
            {
                int[] count = new int[26];

                foreach (var c in word)
                {
                    count[c - 'a']++;
                }

                string key = string.Join(",", count);

                if (!dict.ContainsKey(key))
                {
                    dict[key] = new List<string>();
                }
                dict[key].Add(word);
            }
            return dict.Values.ToList<IList<string>>();

        }
    }
}
