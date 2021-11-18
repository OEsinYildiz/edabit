
namespace Recursion_to_Repeat_a_String_n_Number_of_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            string Repetition(string txt, int n)
            {
                if (n<=1)
                {
                    return txt;
                }
                
                return $"{txt}{Repetition(txt, n-1)}";
            }

            Repetition("cherry", 2);
        }
    }
}