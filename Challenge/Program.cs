using System;

namespace Challenge
{
    class Program
    {
        public static int AddBill(string money)
        {
            string[] arr = money.Split(',');
            int sum = 0;
            foreach (var item in arr)
            {
                var sign = item.Substring(0);
                if (sign == "$")
                {
                    sum += Convert.ToInt32(item);
                }
            }

            Console.WriteLine(sum);
            return sum;
        }
    }
}