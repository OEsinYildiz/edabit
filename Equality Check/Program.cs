using System;

namespace Equality_Check
{
    class Program
    {
        static void Main(string[] args)
        {

            //Equals icerik karsilatirmak icin kullanilir.
            
            string mesaj = "mesaj";
            object message = new string(mesaj);
            
            Console.WriteLine(mesaj==message);
            Console.WriteLine(Equals(mesaj, message));
            Console.WriteLine(mesaj.GetType());
            Console.WriteLine(message.GetType());
            
            static bool CheckEquality(object a, object b)
            {
                bool response = false;

                if (Equals(a.GetType(), b.GetType()))
                {
                    if (Equals(a,b))
                    {
                        response = true;
                    }
                }

                Console.WriteLine(response);
                return response;
            }
            
        }
    }
}