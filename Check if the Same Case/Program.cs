using System;

namespace Check_if_the_Same_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool SameCase(string str)
            {
                if (str==str.ToLower() || str==str.ToUpper())
                {
                    return true;
                }

                return false;
            }
        }
    }
}