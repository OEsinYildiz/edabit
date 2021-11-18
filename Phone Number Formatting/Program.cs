using System;
using System.Text;

namespace Phone_Number_Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            static string FormatPhoneNumber(int[] numbers)
            {
                string phone = String.Concat(numbers);
                return phone.Insert(0, "(").Insert(4, ")").Insert(5, " ")
                    .Insert(9, "-");

            }

            Console.WriteLine(FormatPhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0} ));
            //"(123) 456-7890"
        }
    }
}