using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint4.Task6.V24.Lib;

namespace Tyuiu.PuzyrevIV.Sprint4.Task6.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4.6                                                            *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Пузырев И. В. | СМАРТБ 25 - 1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 5 до 8. Найдите сумму нечетных   *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Минимальный элемент в первом столбце массива: {res}");

            Console.ReadKey();
        }
    }
}
