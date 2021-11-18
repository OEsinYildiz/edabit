using System;
using System.Linq;

namespace Check_if_a_String_Contains_only_Identical_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool isIdentical(string str)
            {
                /*#region MySolutions

                char[] arr = str.ToCharArray();
                bool result = true;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (!Equals(arr[i], arr[0]))
                    {
                        result = false;
                    }
                }
               
                Console.WriteLine(result);
                return result;

                #endregion*/
                var result = str.All(x => x.Equals(str[0]));
                return str.All(x => x.Equals(str[0]));

            }
            isIdentical("aaaaaa");
            isIdentical("aabaaa");
        }
    }
}