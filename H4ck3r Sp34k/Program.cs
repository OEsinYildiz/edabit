using System;
using System.Collections.Generic;
using System.Linq;

namespace H4ck3r_Sp34k
{
    class Program
    {
        static void Main(string[] args)
        {
            static string HackerSpeak(string str)
            {
                /*#region My Solution

                char[] arr = new[] {'a','e','i','o', 's'};
                char[] number = new[] {'4','3','1','0', '5'};
                char[] words = str.ToCharArray();
                string s = str;
                for (int i = 0; i < str.Length; i++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (Equals(words[i], arr[j]))
                        {
                            s = s.Replace(words[i], number[j]);
                        }
                    }
                }
                
                Console.WriteLine(s);
                return s;

                #endregion*/

                #region Dictionary

                var replacement = new Dictionary<char, char>()
                {
                        {'a', '4'},
                        {'e', '3'},
                        {'i', '1'},
                        {'o', '0'},
                        {'s', '5'},
                };

                foreach (var item in replacement)
                {
                    str = str.Replace(item.Key, item.Value);
                }

                Console.WriteLine(str);
                return str;

                #endregion
            }

            HackerSpeak("javascript is cool");
        }
    }
}