using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint4.Task4.V11.Lib;

namespace Tyuiu.PuzyrevIV.Sprint4.Task2.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4.4                                                            *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Пузырев И. В. | СМАРТБ 25 - 1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 5 до 8. Найдите сумму нечетных   *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] numsArray = new int[5, 5] {
                { 8, 7, 7, 8, 5 },
                { 4, 3, 5, 3, 6 },
                { 5, 3, 8, 6, 3 },
                { 6, 3, 8, 5, 4 },
                { 3, 6, 8, 3, 4 }
            };
            int rows = numsArray.GetLength(0);
            int columns = numsArray.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{numsArray[i, j],3}");
                }
                Console.WriteLine();
            }
            int res = ds.Calculate(numsArray);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Минимальный элемент в первом столбце массива: {res}");

            Console.ReadKey();
        }
    }
}
