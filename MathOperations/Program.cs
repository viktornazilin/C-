using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Задача 2
            Console.WriteLine("Задача 2");

            var random = new Random();
            int NumberOne = random.Next(100);
            int NumberTwo = random.Next(100);

            Console.WriteLine(NumberOne);
            Console.WriteLine(NumberTwo);


            if (NumberOne > NumberTwo)
            {
                Console.WriteLine("Первое число больше второго");
            }
            else if (NumberOne < NumberTwo)
            {
                Console.WriteLine("Второе число больше первого");
            }
            else
            {
                Console.WriteLine("Числа равны");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            /// Задача 4
            Console.WriteLine("Задача 4");
            int NumberThree = random.Next(100);

            Console.WriteLine(NumberOne);
            Console.WriteLine(NumberTwo);
            Console.WriteLine(NumberThree);

            if (NumberOne > NumberTwo && NumberOne > NumberThree)
            {
                Console.WriteLine("Первое число наибольшее");
            }
            else if (NumberTwo > NumberOne && NumberTwo > NumberThree)
            {
                Console.WriteLine("Второе число наибольшее");
            }
            else if (NumberThree > NumberOne && NumberThree > NumberTwo)
            {
                Console.WriteLine("Третье число наибольшее");
            }
            else
            {
                Console.WriteLine("Существуют два максимума у данной группы из 3 чисел");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            /// Задача 6
            Console.WriteLine("Задача 6");

            if (NumberOne % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("NumberOne - Число нечетное");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            /// Задача 8. Допустим, что число N - это последний элемент массива.
            
            Console.WriteLine("Задача 8");

            int[] array = new int[30];
            Random rand = new Random();

            for (int y = 0; y < 30; y++)
            {
                array[y] = rand.Next(1, 30);
            }


            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}

