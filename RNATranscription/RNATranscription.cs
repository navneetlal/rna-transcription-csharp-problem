using System;
using System.Text;
using System.Collections.Generic;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {   
                static void Main(string[] args)
                {}
    static readonly IReadOnlyDictionary<char, char> TranslateTable = new Dictionary<char, char>
    {
        ['G'] = 'C',
        ['C'] = 'G',
        ['T'] = 'A',
        ['A'] = 'U',
    };

    public static string ToRna(string nucleotide){

            StringBuilder sb = new StringBuilder(nucleotide); 
              for(int i=0;i<nucleotide.Length;i++){ 
                    sb[i] = TranslateTable[sb[i]];
              }

              return sb.ToString();

    }
          
    }

}
