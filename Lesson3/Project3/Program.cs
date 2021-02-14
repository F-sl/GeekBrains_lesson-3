using System;

namespace Project3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string greeting = "Hello world!";
            for(int i = (greeting.Length - 1); i >= 0; i--)
            {
                Console.Write(greeting[i]);
            }
            Console.WriteLine();
        }
    }
}
