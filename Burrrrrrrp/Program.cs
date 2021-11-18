using System;

namespace Burrrrrrrp
{
    class Program
    {
        static void Main(string[] args)
        {
            static string LongBurp(int b)
            {
                char[] r = new char[b];
                for (int i = 0; i < b; i++)
                {
                    r[i] = 'r';
                }

                Console.WriteLine(String.Concat('B', 'u', new string(r), 'p'));
                return String.Concat('B', 'u', new string(r), 'p');
            }

            LongBurp(5);
        }
    }
}