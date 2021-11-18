using System;
using System.Collections.Generic;
using System.Linq;

namespace Is_the_Word_an_Isogram
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool IsIsogram(string str)
            {
                #region First Solution

                /*str = str.ToLower();
                var distinct = str.Distinct();
                return distinct.Count() == str.Length ? true : false;*/

                #endregion

                str = str.ToLower();
                IEnumerable<char> list = str.ToList();
                var distinct = str.Distinct();
                bool result = list.SequenceEqual(distinct);
                return result;
            }

            Console.WriteLine(IsIsogram("Algorism"));
            Console.WriteLine(IsIsogram("PasSword"));
        }
    }
}