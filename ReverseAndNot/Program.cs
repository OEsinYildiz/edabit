using System;
using System.Linq;
using Microsoft.VisualBasic;

namespace ReverseAndNot
{
    class Program
    {
        static void Main(string[] args)
        {
            static string ReverseAndNot(int i)
            {
                //Concat Kullanimi
                string s = i.ToString();
                var e = s.ToArray();
                Array.Reverse(e);
                return String.Concat(new string(e), s);
            }

            Console.WriteLine(ReverseAndNot(123));
            Console.WriteLine(ReverseAndNot(152));
        }
    }
}