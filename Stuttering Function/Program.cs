using System;
using System.Text;

namespace Stuttering_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            static string Stutter(string word)
            {
                StringBuilder sb = new StringBuilder(word.Substring(0, 2));
                sb.Append("... ");
                sb.Append(sb);
                sb.Append(word);
                sb.Append('?');
                Console.WriteLine(sb.ToString());
                return sb.ToString();

            }

            Stutter("incredible");
        }
    }
}