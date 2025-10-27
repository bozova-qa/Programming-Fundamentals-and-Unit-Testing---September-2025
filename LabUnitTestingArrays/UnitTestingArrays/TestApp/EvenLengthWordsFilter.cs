using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp;

public class EvenLengthWordsFilter
{
    public static string GetEvenWords(string[] words)
    {
        //words = ["table", "car", "mask", "zero]
        StringBuilder result = new StringBuilder();// "mask zero "

        foreach (string word in words)
        {
            if (word.Length % 2 == 0)
            {
                result.Append(word + " ");
            }
        }
        //"mask zero "; Trim.End() -> премахва излишните интервали;
        return result.ToString().TrimEnd();
    }
}

