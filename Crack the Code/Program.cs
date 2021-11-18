using System;
using System.Linq;
using System.Text;

namespace Crack_the_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            static int[] Decode(string str)
            {
                int[] arr = new int[str.Length];
                var result = Encoding.ASCII.GetBytes(str);
                for (int i = 0; i < result.Length; i++)
                {
                    arr[i] = Convert.ToInt32(result[i].ToString().Sum(x=>Char.GetNumericValue(x)));
                }
                
                return arr;
            }

            Console.WriteLine(Decode("hello"));
        }
    }
}