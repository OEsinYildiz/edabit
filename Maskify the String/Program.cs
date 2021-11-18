using System;
using System.Linq;

namespace Maskify_the_String
{
    class Program
    {
        static void Main(string[] args)
        {
            static string Maskify(string str)
            {
                /*#region MyFirstSol

                if (str.Length < 4)
                    return str;
                var nonTransform = str.Substring(str.Length - 4);
                StringBuilder transform = new StringBuilder();
                for (int i = 0; i < str.Length - 4; i++)
                {
                    transform.Append("#");
                }

                return transform.Append(nonTransform).ToString();

                #endregion*/

                /*#region MySecondSol

                if (str.Length < 4)
                    return str;

                string coveredBySharp = str.Substring(str.Length - 4);
                string sharp = new string('#', str.Length - 4);
                return sharp + coveredBySharp;

                #endregion*/
                if (str.Length < 4)
                    return str;
                return string.Create(str.Length, str, (span, value) =>
                {
                    value.AsSpan().CopyTo(span);
                    span[..^4].Fill('#');
                });
            }

            Console.WriteLine(Maskify("35616"));
            Console.WriteLine(Maskify("616"));
            Console.WriteLine(Maskify("64607935616"));
        }
    }
}