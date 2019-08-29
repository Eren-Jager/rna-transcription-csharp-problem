using System;
using System.Collections.Generic;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
           
        {
            string f = "";
            Dictionary<char,char> rule = new Dictionary<char,char>();
            rule.Add('G', 'C');
            rule.Add('C', 'G');
            rule.Add('T', 'A');
            rule.Add('A', 'U');
            for(int i=0;i<nucleotide.Length;i++)
            {
                f += rule[nucleotide[i]];
            }
            return f;
            
        }


        public static void Main()
        {

        }
    }
}
