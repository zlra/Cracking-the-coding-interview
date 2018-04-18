using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{

    /**
     *
     * We have to check does given sentece has all unique characters 
     *
     * Easiest way O(n^2) -> two for loops,check if characters are the same...trival.
     *
     * Second way  -> Sort array and then check if successive characters are the same. Complexity O(n log n)
     *
     * Third way   -> HashMap (Dictionary), Time complexity O(n), Space complexity O(n) - IMPLEMENTED BELOW 
     *
     */

    class StringUniqueCharacters
    {
        public static bool HasAllUniqueCharacters(string sentence)
        {
            bool[] charRepeating = new bool[256];

            for (int i = 0; i < sentence.Length; i++)
            {
                if (charRepeating[sentence[i]] == true)
                    return false;
                charRepeating[sentence[i]] = true; 
            }

            return true; 
        }
    }
}
