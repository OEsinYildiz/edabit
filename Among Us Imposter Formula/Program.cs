using System;
using System.Collections.Concurrent;

namespace Among_Us_Imposter_Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            static string ImposterFormula(int i, int p)
            {
                float result = 100 * (Convert.ToSingle(i)/Convert.ToSingle(p));
                return string.Concat(Math.Round(result).ToString(), "%");
            }

            Console.WriteLine(ImposterFormula(1, 8));
        }
    }
}