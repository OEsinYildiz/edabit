using System;

namespace Smaller_String_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string smallerNum(string n1, string n2)
            {
                return Convert.ToInt32(n1) < Convert.ToInt32(n2) ? n1.ToString() : n2.ToString();
            }
        }
    }
}