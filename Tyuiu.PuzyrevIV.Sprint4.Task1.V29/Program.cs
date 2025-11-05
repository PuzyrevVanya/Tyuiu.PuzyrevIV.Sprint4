using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint4.Task1.V29.Lib;

namespace Tyuiu.PuzyrevIV.Sprint4.Task1.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4.1                                                            *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Пузырев И.В. | СМАРТБ 25 - 1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 9.                          *");
            Console.WriteLine("* Подсчитать сумму нечетных элементов массива.                            *");
            Console.WriteLine("* С клавиатуры: 5, 3, 3, 4, 1, 3, 3, 5, 6, 2, 7, 2, 1, 8                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ВВОД ДАННЫХ:                                                            *");
            Console.WriteLine("***************************************************************************");

            int arrayLength = 14;
            int[] numsArray = new int[arrayLength];

            Console.WriteLine($"Введите {arrayLength} элементов массива (целые числа от 1 до 9):");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Элемент #{i + 1}: ");
                string input = Console.ReadLine();
                int value;

                while (!int.TryParse(input, out value) || value < 1 || value > 9)
                {
                    Console.WriteLine("Ошибка ввода! Пожалуйста, введите целое число от 1 до 9.");
                    Console.Write($"Элемент #{i + 1}: ");
                    input = Console.ReadLine();
                }
                numsArray[i] = value;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЙ МАССИВ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Ваш массив: [");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.Write(numsArray[i]);
                if (i < numsArray.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int sumOfOddElements = ds.Calculate(numsArray);

            Console.WriteLine("Сумма нечетных элементов массива = " + sumOfOddElements);

            Console.ReadKey();
        }
    }
}