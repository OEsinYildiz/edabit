using System;
using System.Text.RegularExpressions;
namespace Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Dot Net Not OEsin";
            string output = System.Text.RegularExpressions.Regex.Replace(input, "N.t", "NET");
        }
    }
}