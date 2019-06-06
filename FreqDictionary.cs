using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ll
{
    class FreqDictionary
    {
        public static Dictionary<string, int> GetFrequenceDictionary(string text)
        {
            //text.Split(new char[] { '.', ',', '\'', '?', ' ', '\t', '\n', ':', ';', '!', '-' })
            List<string> words = Regex.Split(text.ToLower(), @"(\a\r)?\s+|\W+|\d+").ToList();
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i] == "")
                {
                    words.RemoveAt(i);
                }
            }
            return words.GroupBy(g => g).Select(s => new Tuple<string, int>(s.Key, s.Count())).ToDictionary(x => x.Item1, x => x.Item2);
        }
    }
}
