using System;
using System.Linq;
using System.Text;

namespace Reverse_the_Order_of_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            static string Reverse(string str)
            {
                return string.Concat(str.Reverse());

                #region MySol

                char[] arr = str.ToCharArray();
                Array.Reverse(arr);
                return new String(arr);

                #endregion
            }

            Console.WriteLine(Reverse("Hello World"));
        }
    }
}