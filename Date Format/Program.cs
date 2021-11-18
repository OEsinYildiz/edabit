using System;
using System.Linq;
using System.Text;

namespace Date_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            static string FormatDate(string date)
            {
                //return String.Join("",date.Split('/').Reverse());
                
                return Convert.ToDateTime(date).ToString("yyyyddMM");
                
                var result = date.Split('/');
                StringBuilder str = new StringBuilder();
                for (int i = result.Length-1; i >= 0; i--)
                {
                    var st=result[i];
                    str.Append(result[i]);
                }
                return str.ToString();
            }

            Console.WriteLine(FormatDate("11/12/2019"));
        }
    }
}