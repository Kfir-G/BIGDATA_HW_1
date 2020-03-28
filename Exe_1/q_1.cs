/*
using System;

namespace Exe1
{
    class q1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NewNumber(584712));
        }

        static int NewNumber(int num)

        {
            int tempnum = num;
            int count = 0;
            //find the len of the number  
            while (tempnum > 0)
            {
                count++;
                tempnum /= 10;
            }
            tempnum = num;
            int maxnum = tempnum % 10;
            int minnum = tempnum % 10;
            //find min and max numbers.  
            while (tempnum > 0)
            {
                if (tempnum % 10 > maxnum)
                    maxnum = tempnum % 10;
                if (tempnum % 10 < minnum)
                    minnum = tempnum % 10;
                tempnum /= 10;
            }
            tempnum = num;
            num = 0;
            // create new number  
            int m = 10;
            num += minnum;
            for (int i = 0; i <= count - 1; i++)
            {
                if (tempnum % 10 != minnum && tempnum % 10 != maxnum)
                {
                    num += +m * (tempnum % 10);
                    m *= 10;
                }
                tempnum /= 10;
            }
            num += m * maxnum;
            return num;
        }
    }
}*/