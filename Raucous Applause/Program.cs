using System;
using System.Linq;

namespace Raucous_Applause
{
    class Program
    {
        static void Main(string[] args)
        {
            static int CountClaps(string txt)
                => txt.Count(x => x.Equals('C'));


            Console.WriteLine(CountClaps("ClaClaClaClap!"));
            Console.WriteLine(CountClaps("ClClClaClaClaClap!"));
            Console.WriteLine(CountClaps("CCClaClClap!Clap!ClClClap!"));
        }
    }
}