
using System;
using System.Collections.Generic;
using System.Text;

namespace Exe_1
{
    class q_3
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 1, 1 }, { 0, 2, 2}, { 0, 0, 3 } };
            int t = Matrix_triangular(arr);
            if (t == 1)
                Console.WriteLine("It is matrix a triangular upper");
            else
            {
                if (t == 0)
                    Console.WriteLine("It is a matrix triangular down");
                else
                    Console.WriteLine("It is  NOT a matrix triangular");
            }
        }
        static int Matrix_triangular(int [,] arr)
        {
            int cols= arr.GetLength(0);
            int rows= arr.GetLength(1);
            if (cols != rows) // check if its square
                return -1;
            bool temp = true;
            int c,r=0;
            while(r<rows-1 && temp==true) //scanning if its upper
            {
                c = r + 1;
                while (c < cols && temp == true)
                {
                    if (arr[r, c] != 0)
                         temp = false;
                     c++;
                }
            r++;
            }
            if (temp==true)//check after the while loop if its matrix triangular upper
                return 1;
            r=rows-1;
            temp = true;
            while(r>0 && temp==true)
            {
                c =r-1;
                while (c >= 0 && temp == true)
                {
                    if (arr[r, c] != 0)
                        temp = false;
                    c--;
                }
            r--;
            }
            if (temp==true)//check after the while loop if its matrix triangular down
                return 0;
            // if its not the theres so isnt triangular up or down
            return -1;
        }
    }
}
