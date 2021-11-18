using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maximum_Occurrence
{
    class Program
    {
        static void Main(string[] args)
        {
            static string MaxOccur(string text)
            {

                /*#region MySol

                char[] arr = text.OrderBy(x=>x).ToArray();
                Dictionary<char, int> list = new Dictionary<char, int>();
                for (int i = 1; i < text.Length; i++)
                {
                    if (arr[i - 1] == arr[i])
                    {
                        int value = text.Count(x => x == arr[i]);
                        if (!list.ContainsKey(arr[i]))
                            list.Add(arr[i],value);
                    }

                }
                if (list.Count == 0)
                    return "No Repetition";
                var y = list.Values.Max();
                if (list.Keys.Count(x => y == list[x]) > 1)
                {
                    StringBuilder response = new StringBuilder();
                    foreach (var item in list.Keys.Where(x => y == list[x]))
                    {
                        response.Append(item);
                        response.Append(", ");
                    }
                    return response.Remove(response.Length - 2, 2).ToString();
                }
                return list.Keys.Where(x => y == list[x]).FirstOrDefault().ToString();

                #endregion*/

                var group = text.OrderBy(x => x).GroupBy(c => c);
                var max = group.Max(x=>x.Count());
                var d = group.Where(g => g.Count() == max).Select(g => g.ToString()).ToArray();
                return max > 1 ? string.Join(", ", group.Where(g => g.Count() == max).Select(g => g.Key.ToString()).ToArray()) : "No Repetition";
 
            }

            //Console.WriteLine(MaxOccur("Edabit"));
            Console.WriteLine(MaxOccur("system admin"));
            //Console.WriteLine(MaxOccur("Computer Science"));
            //Console.WriteLine(MaxOccur("the quick brown fox jumps over the lazy dog"));
        }
    }
}