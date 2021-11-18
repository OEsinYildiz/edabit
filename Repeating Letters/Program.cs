using System;
using System.Text;

namespace Repeating_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string DoubleChar(string str)
            {
                char[] word = str.ToCharArray();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < str.Length; i++)
                {
                    sb.Append(word[i], 2);
                }

                Console.WriteLine(sb.ToString());
                return sb.ToString();
            }

            DoubleChar("String");
        }
    }
}