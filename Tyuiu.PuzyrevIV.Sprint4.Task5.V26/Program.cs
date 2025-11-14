using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint4.Task5.V26.Lib;

namespace Tyuiu.PuzyrevIV.Sprint4.Task5.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();
            var rnd = new Random();

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* Спринт #4  Тема: Двумерные массивы (генератор)     *");
            Console.WriteLine("* Задание #4.5        Вариант #26                    *");
            Console.WriteLine("* Дан массив 5x5 со случайными значениями -4..4.     *");
            Console.WriteLine("* Заменить положительные элементы на 1.             *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine();

            int[,] matrix = new int[5, 5];
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    matrix[i, j] = rnd.Next(-4, 5);

            Console.WriteLine("Исходный массив:");
            PrintMatrix(matrix);

            int[,] result = ds.Calculate(matrix);

            Console.WriteLine();
            Console.WriteLine("Массив после замены положительных элементов на 1:");
            PrintMatrix(result);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        static void PrintMatrix(int[,] mat)
        {
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{mat[i, j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}
