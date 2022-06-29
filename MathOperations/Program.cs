using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 19
            
            Console.WriteLine("Задача 19");

            Console.WriteLine("Введите число.");

            string input2 = Console.ReadLine();

            int[] arr2 = input2.ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();

            if (arr2.Length == 5)
            {
                if (arr2[0] == arr2[4] && arr2[1] == arr2[3])
                {
                    Console.WriteLine("Введенное число - палиндром");
                }
                else
                {
                    Console.WriteLine("Введенное число -  НЕ палиндром");
                }
            }
            else
            {
                Console.WriteLine("Число не пятизначное");
            }

            Console.WriteLine();
            

            // Задача 21
            Console.WriteLine("Задача 21");

            Console.WriteLine("Введите координаты первого вектора");
            string input1 = Console.ReadLine();
            float vectorX1 = Convert.ToSingle(input1);
            string input2 = Console.ReadLine();
            float vectorY1 = Convert.ToSingle(input2);
            string input3 = Console.ReadLine();
            float vectorZ1 = Convert.ToSingle(input3);


            float[] vectorArr1 = new float[3];
            vectorArr1[0] = vectorX1;
            vectorArr1[1] = vectorY1;
            vectorArr1[2] = vectorZ1;

            Console.WriteLine("Введите координаты второго вектора");
            string input4 = Console.ReadLine();
            float vectorX2 = Convert.ToSingle(input4);
            string input5 = Console.ReadLine();
            float vectorY2 = Convert.ToSingle(input5);
            string input6 = Console.ReadLine();
            float vectorZ2 = Convert.ToSingle(input6);

            float[] vectorArr2 = new float[3];
            vectorArr2[0] = vectorX2;
            vectorArr2[1] = vectorY2;
            vectorArr2[2] = vectorZ2;

            Console.WriteLine("Расстояние между векторами:");
            Console.WriteLine(VectorDistance(vectorArr1, vectorArr2));
            
            Console.WriteLine();

            // Задача 23
            Console.WriteLine("Задача 23");
            Console.WriteLine("Введите число.");

            string numberInput = Console.ReadLine();
            int numberN = int.Parse(numberInput);
            int n = numberN;
            while (n <= numberN)
            {
                Console.WriteLine(n*n*n);
                n -= 1;

                if (n <= 0)
                {
                    break;
                }
                
            }
                

            


        }

        
        public static float VectorDistance(float[] vector1, float[] vector2)
        {
            if (vector1.Length == 3 && vector2.Length == 3)
            {
                float x = (vector1[0] - vector2[0]);
                float xstep = MathF.Pow(x, 2);
                Console.WriteLine(xstep);
                float y = (vector1[1] - vector2[1]);
                float ystep = MathF.Pow(y, 2);
                Console.WriteLine(ystep);
                float z = (vector1[2] - vector2[2]);
                float zstep = MathF.Pow(z, 2);
                Console.WriteLine(zstep);
                float distance = xstep + ystep + zstep;
                float distanceRoot = MathF.Sqrt(distance);
                return distanceRoot;
            }
            else
            {
                return 0;
            }
            
        }
    }
    
}

