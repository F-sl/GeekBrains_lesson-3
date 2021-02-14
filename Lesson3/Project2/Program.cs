using System;

namespace Project2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Фамилии в стравочнике:\n");
           
            string[] firstName =
            {
                "Комаров",
                "Сикерин",
                "Корнеев",
                "Плотников",
                "Захаров",
            };
            string [] numbers = 
            {
                "89086201425",
                "89620532684",
                "89260452985",
                "89857531680",
                "89156102850"
            };

            for (int i = 0; i < firstName.Length; i++)
            {
                Console.WriteLine(firstName[i]);
            }
            Console.WriteLine("\nВведите фамилию, чтобы увидеть номер");

            string userFirstName = Console.ReadLine();
            bool isFound = false;

            for(int i = 0; i < firstName.Length; i++)
            {
                if(firstName[i] == userFirstName)
                {
                    Console.WriteLine($"\nФамилия: {userFirstName}, номер телефона: {numbers[i]}");
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Номера для этой фамилии нет.");
            }
        }
    }
}
