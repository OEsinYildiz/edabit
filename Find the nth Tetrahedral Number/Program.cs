using System;

namespace Find_the_nth_Tetrahedral_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            static int Tetra(int n)
            {
                return n * (n + 1) * (n + 2) / 6;
            }

            Console.WriteLine(Tetra(6));
        }
        
    }
}