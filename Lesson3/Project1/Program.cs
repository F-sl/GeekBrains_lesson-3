using System;

namespace Project1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int [,] nums = { { 1, 4, 7 }, { 3, 6, 9 } };
            for(int i = 0; i < 2; i++)
            {
                 for(int j = 0; j < 3; j++)
                {
                    Console.Write(nums[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Двумерный массив\n");

            Console.WriteLine("\nЭлементы по диагонали");

            for (int o = 0; o < 2; o++)
            {
                while (o < 2)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (o == k)
                        {
                            Console.Write(nums[o, k]);
                        }
                    }
                    break;
                }
            }
            

            Console.WriteLine();
        }
    }
}
