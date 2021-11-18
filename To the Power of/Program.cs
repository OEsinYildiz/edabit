using System;

namespace To_the_Power_of
{
    class Program
    {
        static void Main(string[] args)
        {
            long CalculateExponent(long number, long exponent)
            {
                return Convert.ToInt64(Math.Pow(number, exponent));
            }
        }
    }
}