/*
using System;
using System.Collections.Generic;
using System.Text;

namespace Exe_1
{
    class q_4
    {
        static void Main(string[] args)
        {
            string [] arr= new string[] { "aa", "ss","d", "a", "abc","ab" };
            string longestWord=Sorting_string(arr);
            Console.WriteLine("The Longest word is ---->>>{0}",longestWord);
        }
        static string Sorting_string(string [] arr)
        {
            Array.Sort(arr, StringComparer.InvariantCulture); //sorting alphabetically
            int maxLetter = -1, idx = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}", arr[i]);
                if (arr[i].Length > maxLetter) //check if its the longest
                {
                    maxLetter = arr[i].Length;
                    idx = i;
                }
            }
            return arr[idx];
        }
    }
}
*/