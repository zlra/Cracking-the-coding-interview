using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{

    /*
     *
     * Write a program to reverse string
     *
     */
    class StringReverser
    {
        public static string StringReverse(string sentence)
        {
            StringBuilder sb = new StringBuilder(sentence); 

            for (int i = 0; i < sentence.Length / 2; i++)
            {
                char temp = sb[i];
                sb[i] = sb[sb.Length - 1 - i];
                sb[sb.Length - 1 - i] = temp; 
            }

            return sb.ToString();
        }
    }
}
