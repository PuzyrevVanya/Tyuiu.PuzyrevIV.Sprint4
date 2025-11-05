using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint4.Task0.V16.Lib;

namespace Tyuiu.PuzyrevIV.Sprint4.Task0.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статическое выделение памяти)                 *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Пузырев И.В. | СМАРТБ 25 - 1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9.                          *");
            Console.WriteLine("* Подсчитать произведение четных элементов массива.                       *");
            Console.WriteLine("* Исходный массив: {2, 6, 2, 3, 4, 5, 4, 9, 7, 8}                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };

            Console.Write("Массив: [");
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

            int result = ds.GetMultEvenArrEl(numsArray);

            Console.WriteLine("Произведение четных элементов массива = " + result);

            Console.ReadKey();
        }
    }
}