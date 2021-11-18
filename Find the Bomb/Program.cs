using System;

namespace Find_the_Bomb
{
    class Program
    {
        static void Main(string[] args)
        {
            static string Bomb(string txt)
            {
                var textLower = txt.ToLower();
                if (textLower.Contains("bomb"))
                {
                    return "Duck!!!";
                }
                return "There is no bomb, relax.";
            }
            
            Bomb("Hey, did you think there is a bomb?");
        }
    }
}