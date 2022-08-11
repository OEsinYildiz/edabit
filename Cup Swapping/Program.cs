using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Cup_Swapping
{
    class Program
    {
        static void Main(string[] args)
        {
            static string CupSwapping(string[] swaps)
            {
                
                
                
                Dictionary<char, int> cups = new Dictionary<char, int>();
                cups.Add('A', 0);
                cups.Add('B', 1);
                cups.Add('C', 0);


                int emptyLetter;
                foreach (var item in swaps)
                {
                    /*for (int i = 1; i < item.Length; i++)
                    {
                        emptyLetter = cups[item[0]];
                        cups[item[i-1]] = cups[item[i]];
                        cups[item[i]] = emptyLetter;
                    }*/
                    // (cups[item[0]], cups[item[1]])  = (cups[item[1]], cups[item[0]]);
                    emptyLetter = cups[item[0]];
                    cups[item[0]] = cups[item[1]];
                    cups[item[1]] = emptyLetter;
                }


               return (cups.First(x => x.Value == 1).Key).ToString();
                
            }

           Console.WriteLine(CupSwapping(new string[]{"AB", "CA"}));
           Console.WriteLine(CupSwapping(new string[]{"AC", "CA", "CA", "AC"}));
           Console.WriteLine(CupSwapping(new string[]{"BA", "AC", "CA", "BC"}));
        }
    }

    
}