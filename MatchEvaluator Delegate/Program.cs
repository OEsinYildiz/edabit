using System;
using System.Text.RegularExpressions;

namespace MatchEvaluator_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            string sInput, sRegex;
            sInput = "aabbccddeeff";

            sRegex = "bb";

            Regex r = new Regex(sRegex);

            MyClass c = new();
            MatchEvaluator myEvaluator = new MatchEvaluator(c.ReplaceBB);

            string sOutput = r.Replace(sInput, myEvaluator);
            Console.WriteLine(sOutput);
        }

        public class MyClass
        {
            public static int i = 0;

            public string ReplaceBB(Match match)
            {
                i++;
                return i.ToString() + i.ToString();
            }
        }
    }
}