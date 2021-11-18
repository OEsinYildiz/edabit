using System;
using System.Collections.Generic;
using System.Linq;

namespace Clear_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool Brackets(string str)
            {
                
                Stack<char> brackets = new Stack<char>();
                foreach(var c in str)
                {
                    if(c != '(' && c != ')') 
                        continue;
                    
                    if(c == '(') 
                        brackets.Push('(');
                    
                    else if( c == ')' && brackets.Count != 0) 
                        brackets.Pop();
                    
                    else 
                        return false;				
                }
                return true;
                
                
                bool result = false;
                if (!str.Contains('(') && !str.Contains(')'))
                    return true;
                if (str.Count(x => x.Equals('(')) != str.Count(x => x.Equals(')')))
                    return result = false;
                
                //Todo:Look At Here
                if (str.Select(x=>x).Last()=='(')
                    return false;
                
                int openBracket = 0;
                int closeBracket = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    openBracket += str.IndexOf('(');
                    closeBracket += str.IndexOf(')');
                }

                if (openBracket < closeBracket)
                    result = true;

                return result;
            }

            //Console.WriteLine(Brackets("(a*(b-c)..... )"));
            //Console.WriteLine(Brackets(")(a-b-45/7*(a-34))"));
            Console.WriteLine(Brackets("sin(90...)+.............cos1)"));
            Console.WriteLine(Brackets("(...).!.)...("));
        }
    }
}