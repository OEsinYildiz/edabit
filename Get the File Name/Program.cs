using System;
using System.IO;
using System.Linq;

namespace Get_the_File_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            static string GetFilename(string path)
            {
                var arr = path.Split('.');
                var names = arr[0].Split('/');
                var name=names.Last();
                return path.Split('/').Last();
                return Path.GetFileName(path);
                return string.Concat(name + '.' + arr[1]);
            }

            Console.WriteLine(GetFilename("C:/Projects/pil_tests/ascii/edabit.txt"));
        }
    }
}