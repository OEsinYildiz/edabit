using System;
using System.Text;

namespace Re_Form_the_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            static string GetWord(string left, string right)
            {
                var str = left.Substring(0, 1).ToUpper();
                StringBuilder stringBuilder = new StringBuilder(str);
                stringBuilder.Append(left.Substring(1));
                stringBuilder.Append(right);
                return stringBuilder.ToString();
            }

            Console.WriteLine(GetWord("seas", "onal"));
        }
    }
}