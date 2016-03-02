using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3];

            Console.WriteLine("Ввод массива размером [2;3]");
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Введите элемент массива по месту [{0},{1}]", i, j);
                    arr[i, j] = Int32.Parse(Console.ReadLine());
                }

            Console.Clear();

            Console.WriteLine("Массив");
            PrintArray(arr);

            Console.WriteLine("Минимальный элемент массива: {0}", FindMin(arr));

            Console.WriteLine("Максимальный элемент массива: {0}", FindMax(arr));

            ChangeMaxMin(ref arr);
            Console.WriteLine("Изменённый массив");
            PrintArray(arr);


            Console.ReadKey();
        }

        static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }
        }

        static int FindMin(int[,] arr)
        {
            int min = arr[0, 0];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    if (min >= arr[i, j])
                        min = arr[i, j];
            return min;
        }

        static int FindMax(int[,] arr)
        {
            int max = arr[0, 0];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    if (max <= arr[i, j])
                        max = arr[i, j];
            return max;
        }

        static void ChangeMaxMin(ref int[,] arr)
        {
            int min = FindMin(arr);
            int max = FindMax(arr);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (arr[i, j] == min)
                    {
                        arr[i, j] = max;
                        continue;
                    }
                    if (arr[i, j] == max)
                    {
                        arr[i, j] = min;
                        continue;
                    }
                }
        }
    }
}
