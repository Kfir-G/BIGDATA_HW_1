/*
using System;
using System.Collections.Generic;
using System.Text;
namespace Exe_1
{
    class q_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter a word:");
            string str2 = Console.ReadLine();
            int countCapital = 0, countSmall = 0;
            compareStrings(str1, str2, ref countCapital, ref countSmall);
            Console.WriteLine("Capital letters:{0}\nSmall Letters:{1}", countCapital,countSmall);
        }
        static void compareStrings(string str1, string str2, ref int countCapital, ref int countSmall)
        {
            char[] charsStr1 = str1.ToCharArray(); //convert the strings too arrays of characters
            char[] charsStr2 = str2.ToCharArray();
            for (int i = 0; i<str1.Length; i++)
            {
                if (charsStr1[i] == charsStr2[i]) //check if the letters are equals
                {
                    if (charsStr1[i] >= 'A' && charsStr1[i] <= 'Z') //check if its capital letter
                        countCapital++;
                    else
                        countSmall++;
                }
            }
            return;
        }
    }
}
*/