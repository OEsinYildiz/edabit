using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Uncensor
{
    class Program
    {
        static void Main(string[] args)
        {
            static string Uncensor(string txt, string vowels)
            {
                int i = -1;
                /*string Replace(Match match)
                {
                    var rtn=  vowels.ToArray();
                    i++;
                    return rtn[i].ToString();
                }*/
                string sRegex = @"\*";
              
                Regex r = new Regex(sRegex);
                MyClass c = new MyClass(vowels);
                MatchEvaluator matchEvaluator = new MatchEvaluator (c.Replace);
                return r.Replace(txt, matchEvaluator);
            }

            Console.WriteLine(Uncensor("*PP*RC*S*", "UEAE"));
            Console.WriteLine(Uncensor("abcd", ""));
            Console.WriteLine(Uncensor("Wh*r* d*d my v*w*ls g*?", "eeioeo"));
        }
    }

    public class MyClass
    {
        private int i = -1;
        private string vowels;
        public MyClass(string s)
        {
            vowels = s;
        }
        public string Replace(Match match)
        {
            var rtn=  vowels.ToArray();
            i++;
            return rtn[i].ToString();
        }
    }
}