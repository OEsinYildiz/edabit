using System;

namespace Equality_of_3_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int Equal(int a, int b, int c)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine(3);
                    return 3;
                }else if ( a == b || b == c || a == c)
                {
                    Console.WriteLine(2);
                    return 2;
                }
                else
                {
                    Console.WriteLine(0);
                    return 0;
                }
                
            }

            Equal(3, 4, 3);
            Equal(1, 1, 1);
            Equal(3, 4, 1);
        }
    }
}