using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 10

            
            
            Console.WriteLine("Задача 10");

            Console.WriteLine("Введите трехзначное число.");

            string input = Console.ReadLine();

            int[] arr = input.ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();

            Console.WriteLine(string.Join("-", arr));

            Console.WriteLine(arr[1]);

            Console.WriteLine();

            // Задача 13
            Console.WriteLine("Задача 13");

            Console.WriteLine("Введите число.");

            string input2 = Console.ReadLine();

            int[] arr2 = input2.ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();

            if (arr2.Length < 3)
            {
                Console.WriteLine("Третьей цифры нет");

            }
            else
            {
                Console.WriteLine(arr2[2]);
            }

            Console.WriteLine();

            // Задача 15
            Console.WriteLine("Задача 15");

            string[] Days = new string[8] {"Такого дня недели нет", "Нет", "Нет", "Нет", "Нет", "Нет", "Да", "Да"};

            Console.WriteLine("Введите день недели числом. Например, понедельник - 1, суббота - 6");

            string input3 = Console.ReadLine();

            int DayNumber = Convert.ToInt32(input3);

            Console.WriteLine("День недели - выходной?");

            if (DayNumber == 0)
            {
                Console.WriteLine(Days[0]);
            }
            else
            {
                Console.WriteLine(Days[DayNumber]);
            }
     
        }

            

    
    }
}

