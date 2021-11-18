using System;
using System.Collections.Generic;
using System.Linq;

namespace Power_Ranger
{
    class Program
    {
        static void Main(string[] args)
        {
            static int PowerRanger(int power, int min, int max)
            {
                int x = 0;
                List<int> myValues = new List<int>();
                myValues.AddRange(Enumerable.Range(min,max-min+1));
                for (int i = 1; i <=(int)Math.Sqrt(max); i++)
                {
                    if (myValues.Contains((int) Math.Pow(i, power)))
                        x++;
                }
                return x;
            }

               

            //Console.WriteLine(PowerRanger(3, 1, 27));
            //Console.WriteLine(PowerRanger(10, 1, 5));
            //Console.WriteLine(PowerRanger(2, 49, 65));
            Console.WriteLine(PowerRanger(1, 1, 5));
        }
    }
}