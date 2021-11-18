using System;
using System.Linq;

namespace Xs_and_Os
{
    class Program
    {
        static void Main(string[] args)
        {
            /*#region MySol

            static bool XO(string str)
            {
                bool rtn = false;
                str = str.ToLower();
                if (str.Count(x => x.Equals('x')) == 0 && str.Count(x => x.Equals('o')) == 0)
                {
                    rtn = true;
                }

                if (str.Count(x => x.Equals('x')) == str.Count(x => x.Equals('o')))
                {
                    rtn = true;
                }


                return rtn;
            }

            #endregion*/

            static bool XO(string str) =>
                str.Count(x => x.Equals('x') || x.Equals('X')) == str.Count(x => x.Equals('o') || x.Equals('O'));

            Console.WriteLine(XO("ooxx"));
            Console.WriteLine(XO("xooxx"));
            Console.WriteLine(XO("zpzpzpp"));
            Console.WriteLine(XO("zzoo"));
            Console.WriteLine(XO("ooxXm"));
        }
    }
}