using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PuzyrevIV.Sprint4.Task4.V11.Lib
{
    public class DataService : ISprint4Task4V11
    {
        public int Calculate(int[,] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            if (rows == 0 || cols == 0)
                throw new ArgumentException("Массив не может быть пустым.", nameof(array));

            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int val = array[i, j];
                    if (val % 2 != 0)
                        sum += val;
                }
            }

            return sum;
        }
    }
}
