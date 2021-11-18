using System;
using System.Linq;
using Microsoft.VisualBasic;

namespace Alphabet_Soup
{
    class Program
    {
        static void Main(string[] args)
        {
            static string AlphabetSoup(string str)
            {
                #region MySol

                /*char[] arr = str.ToCharArray();
                Array.Sort(arr);
                String result = new String(arr);
                return result;*/

                #endregion

                return new String(str.OrderBy(x => x).ToArray());
            }

            Console.WriteLine(AlphabetSoup("hello"));
        }
    }
}