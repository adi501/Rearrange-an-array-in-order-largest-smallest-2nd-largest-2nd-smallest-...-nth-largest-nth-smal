# Rearrange-an-array-in-order-largest-smallest-2nd-largest-2nd-smallest-...-nth-largest-nth-smal
Rearrange an array in order – largest,smallest, 2nd largest , 2nd smallest,... nth largest, nth smallest

Input is Array of integers. task is to check if any duplicates is there need to print like "Invalid Input". if duplicates not there we need to print like.

1st Largest Number, 1st smallest number, 2nd largest number, 2nd smallest number,....nth largest number, nth smallest..

You can see Examples in below:

Example 1: 

 Input: arr[] = [5, 8, 1, 4, 2,2, 9, 3, 7, 6]

 Output: Invalid Input

Example 2: 

Input: arr[] = [1,3,4,2,5,7,9,8,6]

Output:

9

1

8

2

7

3

6

4

5



Solution in C#.net



using System;

using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = new int[] { 1, 2, 3, 4, 5, 7, 8, 9, 6 };
            BigAndSmallNumbers(input1);
            Console.ReadKey();
        }
        public static void BigAndSmallNumbers(int[] input1)
        {
            bool duplicate = false;
            for (int i = 0; i < input1.Length; i++)
            {
                for (int j = i + 1; j < input1.Length; j++)
                {
                    if (input1[i] == input1[j])
                    {
                        duplicate = true;
                    }
                }
            }
            if (duplicate == false)
            {
                Array.Sort(input1);
                Array.Reverse(input1);
                int n = input1.Length;
                int ArrIndex = 0;
                int[] output = new int[input1.Length];
                for (int i = 0, j = n - 1; i <= n / 2 || j > n / 2; i++, j--)
                {
                    if (ArrIndex < n)
                    {
                        output[ArrIndex] = input1[i];
                        ArrIndex++;
                    }
                    if (ArrIndex < n)
                    {
                        output[ArrIndex] = input1[j];
                        ArrIndex++;
                    }
                }
                foreach (var a in output)
                {
                    Console.WriteLine(a);
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}








