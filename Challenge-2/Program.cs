using System;
using System.Linq;

namespace Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int AddBill(string money)
            {
                string[] arr = money.Split(new []{',', ' '});
                int sum = 0;
                foreach (var item in arr)
                {
                    if (item.Contains('$'))
                    {
                        
                        if (item.Contains('k'))
                        {
                            var item2 = item.Substring(1, item.IndexOf('k')-1);
                            
                            sum += Convert.ToInt32(item2)*1000;
                        }
                        else
                        {
                            sum += Convert.ToInt32(item.Substring(1));
                        }
                    }
                }

                Console.WriteLine(sum);
                return sum;
            }

            #region Another Solution

           static int AddBill2(string money)
            {
                return money.Split(new string[] {", "}, StringSplitOptions.None)
                    .Where(amt => amt[0] == '$')
                    .Select(amt => int.Parse(amt.Replace("k", "000").Substring(1)))
                    .Sum();
            }

            #endregion

            AddBill("$200, £40, £60, $1k");
        }
        
    }
}