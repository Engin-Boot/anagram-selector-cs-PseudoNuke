using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramSelector
    {
        public bool WordPairIsAnagram(string word1, string word2) {
            //Insert the correct implementation here
            char[] word1_array = word1.ToLower().ToCharArray();
            char[] word2_array = word2.ToLower().ToCharArray();
            
            Array.Sort(word1_array);
            Array.Sort(word2_array);
            
            string _word1 = new string(word1_array);
            string _word2 = new string(word2_array);
            
            if(_word1 == _word2)
                return true;
            else
                return false;
        }
        public List<string> SelectAnagrams(string word, List<string> candidates) {
            //Insert the correct implementation here
            for( int i = 0; i < candidates.Count; i++)
            {
                if(WordPairIsAnagram(word, candidates[i]) == false)
                {
                    candidates.Remove(candidates[i]);
                    i--;
                }
            }
            
            return candidates;
        }
    }
}
