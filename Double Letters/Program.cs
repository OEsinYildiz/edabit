using System;
using System.Linq;

namespace Double_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool DoubleLetters(string word)
            {
                /*#region MySolution

                bool result = false;
                char[] arr =word.ToCharArray();
                char[] letter =  word.ToCharArray();


                for (int i = 0; i < arr.Length-1; i++)
                {
                    if (letter[i] == arr[i+1])
                    {
                        result = true;
                    }
                }

                return result;

                #endregion*/

                bool result = false;

                for (int i = 1; i < word.Length; i++)
                {
                    if (word[i-1] == word[i]) result = true;
                }

                return result;
            }

            Console.WriteLine(DoubleLetters("loop"));
            Console.WriteLine(DoubleLetters("orange"));
            ;
        }
    }
}