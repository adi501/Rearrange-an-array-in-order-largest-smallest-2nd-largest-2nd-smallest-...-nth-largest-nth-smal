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
