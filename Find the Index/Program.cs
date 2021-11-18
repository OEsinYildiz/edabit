using System;
using System.Linq;

namespace Find_the_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            static int Search(int[] arr, int item)
            {
                // return !arr.Contains(item) ? -1 : Array.IndexOf(arr, item);
                
                if (arr.Length == 0) return -1;
		
                var index = arr.Length -1;
                if (arr[index] == item) return index;
		
                var nextArr = new int[index];
                for (int i = 0; i < index; i++)
                {
                    nextArr[i] = arr[i];
                }
                return Search(nextArr, item);
            }
        }
    }
}