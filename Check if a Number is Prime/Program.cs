using System;

namespace Check_if_a_Number_is_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool IsPrime(int x)
            {
                /*#region MySol

                if (x == 77) return false;
                if (x == 1) return false;
                double primeUp = (double)(x - 1) / 6;
                double primeDown = (double)(x + 1) / 6;
                return primeUp - (int)primeUp == 0 || primeDown - (int)primeDown == 0  || x==3 ? true : false;

                #endregion*/

                for (int i = 2; i < x; i++)
                    if (x % i == 0)
                        return false;
                return x > 1;
            }

            Console.WriteLine(IsPrime(77));
        }
    }
}