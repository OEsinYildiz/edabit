using System;
using System.Text.RegularExpressions;

namespace Use_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "marcus aurelius";
            //string output = Regex.Replace(input, "N.t", "NET");
            Console.WriteLine(TextTools.UpperCase(input));
            //Console.WriteLine(output);
        }
    }

    public static class TextTools
    {
       public static string UpperCase(string s)
        {
            return Regex.Replace(s, @"\b[a-z]\w+", delegate(Match match)
            {
                string v = match.ToString();
                return char.ToUpper(v[0]) + v.Substring(1);
            });
        }
    }
}